using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;

public class CharacterControls : MonoBehaviour
{
    [HideInInspector]
    public float fInput;
    Vector3 direction;
    [SerializeField]
    public float speed;


    //////////////Jumping//////////////
    bool grounded;
    [Tooltip("How fast the player jumps")]
    public float JumpVel;
    [Tooltip("Max jump time (for setting a maximum jump height)")]
    public float JumpTime;
    [Tooltip("Tracks how long you've been jumping")]
    float JumpTimeCounter;
    bool StoppedJumping;

    public LayerMask LayerMask;
    //////////////Jumping//////////////

    [Tooltip("Key input type (WASD / Key(arrows)) for debugging without controller")]
    public string type;
    [Tooltip("Maximum velocity")]
    public float maxSpeed;

    Rigidbody rb;
    [Tooltip("How much gravity you want")]
    public float gravityforce;
    Vector3 gravity;
    float m_JumpVel;

    //CHECK FOR GROUNDED
    int DistToGround;

    //XINPUT REQS
    [Tooltip("Player #, needed for input controls")]
    public PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;

    public float friction;

    public float SlowPercent;
    public float AccelAmount;

    float InitialMaxSpeed;

    float lerp = 0.0f;

    public float movementRayLength = 2;
    Vector3 movementPosition;

    public LayerMask Ground;
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    {
        JumpTimeCounter = JumpTime;
        speed = maxSpeed / 2;
        InitialMaxSpeed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        HandleXinput();
        if (speed > maxSpeed)
        {
            speed -= Time.deltaTime * 5;
        }

        grounded = IsGrounded();

        //transform.Translate(direction);
        if (grounded)
        {
            //if grounded reset gravity and jump velocity
            gravity = new Vector3(0, gravityforce, 0);
            m_JumpVel = JumpVel;
            //JumpTimeCounter = JumpTime;
        }
    }


    //all xinput inputs
    void HandleXinput()
    {
        //get controller state
        currentState = GamePad.GetState(playerIndex);
        lerp = 0.02f;

        //if controller index isn't connected
        if (!currentState.IsConnected)
        {
            //break out of function
            return;
        }

        //bounds
        if (fInput > 1)
        {
            fInput = 1;
        }
        if (fInput < -1)
        {
            fInput = -1;
        }
        //end bounds

        //if fInput is within bounds
        if (fInput <= 1 && fInput >= -1)
        {
            //add current stick input to fInput
            fInput += currentState.ThumbSticks.Left.X;
        }
        if (fInput != 0 && currentState.ThumbSticks.Left.X == 0)
        {
            //if the stick isnt being used move fInput to zero (slows down when you stop moving)
            fInput = Mathf.Lerp(fInput, 0, lerp);
        }

        //if you're using the stick
        if (currentState.ThumbSticks.Left.X != 0)
        {
            //if current speed isnt maxSpeed
            if (speed < maxSpeed)
            {
                //speed up
                speed += Time.deltaTime * 7;
            }
            else if (speed > maxSpeed)
            {
                speed -= Time.deltaTime;
            }
        }
        //if you aren't using the stick
        else if (currentState.ThumbSticks.Left.X == 0)
        {
            //if speed is greater than half maxSpeed
            if (speed > maxSpeed / 2)
            {
                //speed = half maxSpeed
                speed = maxSpeed / 2;
            }
        }

        //jump by pushing A
        if (previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Pressed)
        {
            if (grounded)
            {
                //jump!
                rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
                StoppedJumping = false;
                JumpTimeCounter = JumpTime;
            }
        }

        if (!StoppedJumping)
        {
            //and your counter hasn't reached zero...
            if (JumpTimeCounter > 0)
            {
                //keep jumping!
                rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
                JumpTimeCounter -= Time.deltaTime;
            }
        }

        //if you have released a and minimum jump is reached
        //or you jump for the full time
        if ((previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Released && JumpTimeCounter <= JumpTime - Time.deltaTime) || JumpTimeCounter <= 0)
        {
            //stop jumping
            JumpTimeCounter = 0;
            StoppedJumping = true;
        }

        previousState = currentState;
    }


    //Uses collision events and calculates if your object is inside a different one
    //handy for making sure you dont go inside other things
    private void FixedUpdate()
    {
        //movementPosition = rb.position + transform.right * fInput * speed * Time.fixedDeltaTime;
        movementPosition = CheckMovementPosition(movementPosition, Mathf.Sign(fInput));

        //movement force
        rb.MovePosition(movementPosition);

        ////////////////////////Start Gravity////////////////////////
        if ((!grounded || rb.velocity.y > 0 || rb.velocity.y < 0) /*&& StoppedJumping*/)
        {
            if (gravity.y >= -100)
            {
                //grav increase over time
                gravity += new Vector3(0, gravityforce, 0);

            }

        }
        rb.AddForce(gravity);
        ////////////////////////End Gravity////////////////////////

        ////////////////////////Start jump reduction////////////////////////
        if (!StoppedJumping)
        {
            if (m_JumpVel > JumpVel / 2)
            {
                m_JumpVel -= 5;
            }
        }
        ////////////////////////End jump reduction////////////////////////
    }

    public void Slow()
    {
        StartCoroutine("slow");
        //StopCoroutine("slow");
    }

    //divide maxSpeed by whatever wait 2 seconds and restore
    IEnumerator slow()
    {
        yield return new WaitForSeconds(2f);
    }

    //Multiplied max speed by 2 then waits for 2 seconds 
    public IEnumerator speedUp(float a_SpeedIncrease)
    {
        speed *= a_SpeedIncrease;
        yield return new WaitForSeconds(0.5f);
    }


    //doesnt do anything yet
    IEnumerator stun()
    {
        yield return new WaitForSeconds(5f);
    }


    //Casts 3 rays to the right or left depending on current direction
    //Checks if any rays hit a wall
    //if it does it saves the length of the ray from origin to hitpoint
    //changes movement position to equal length of shortest ray
    //else it doesnt change movement position
    private Vector3 CheckMovementPosition(Vector3 positionToMoveTo, float dirValue)
    {
        RaycastHit[] hit = new RaycastHit[3];
        RaycastHit leastDist = new RaycastHit();

        for (int i = 0; i < 3; i++)
        {
            Debug.DrawRay(transform.position + Vector3.up * ((i - 1) * 0.5f), Vector3.right * movementRayLength * dirValue, Color.blue);
            if (Physics.Raycast(transform.position + Vector3.up * ((i - 1) * 0.5f), Vector3.right * dirValue, out hit[i], movementRayLength, Ground))
            {
                //if current rayHit is greater than the leastDist
                if (hit[i].distance > leastDist.distance)
                {
                    //leastDist will always equal the shortest ray
                    leastDist = hit[i];
                }
            }
        }

        //if leastDist was changed to the length of a raycast
        if (leastDist.distance != 0)
        {
            //point to move to is now the current position + least distance ray * deltaTime
            return rb.position + Vector3.right * leastDist.distance * Time.deltaTime;
        }
        else
            //else point to move to stays the same
            return rb.position + transform.right * fInput * speed * Time.fixedDeltaTime;
    }

    //cast a ray to the see if the player is stuck to the left of an objcet
    //not being used
    bool IsStuckLeft()
    {
        // List<RaycastHit> rayList = new List<RaycastHit>();
        for (int i = 0; i < 3; i++)
        {
            RaycastHit hit;

            Debug.DrawRay(transform.position + Vector3.up * ((i - 1) * 0.5f), Vector3.right * movementRayLength, Color.blue);
            if (Physics.Raycast(transform.position + Vector3.up * ((i - 1) * 0.5f), Vector3.right, out hit, movementRayLength))
            {
                fInput = 0;

                return true;
            }
        }

        //Debug.DrawRay(transform.position, Vector3.right * movementRayLength , Color.blue);
        //if (Physics.Raycast(transform.position, Vector3.right * movementRayLength , 0.6f, 1))
        //{
        //    fInput = 0;
        //    return true;
        //}

        //Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Vector3.right * movementRayLength, Color.blue);
        //if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Vector3.right, 0.6f, 1))
        //{
        //    fInput = 0;
        //    return true;
        //}

        //Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), new Vector3(0.6f, 0, 0), Color.blue);
        //if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.right, 0.6f, 1))
        //{
        //    fInput = 0;
        //    return true;
        //}

        return false;
    }


    //cast a ray to the see if the player is stuck to the right of an objcet
    //not being used
    bool IsStuckRight()
    {
        Debug.DrawRay(transform.position, new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(transform.position, Vector3.left, 0.6f, 1))
        {
            fInput = 0;
            return true;
        }
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Vector3.left, 0.6f, 1))
        {
            fInput = 0;
            return true;
        }
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.left, 0.6f, 1))
        {
            fInput = 0;
            return true;
        }

        else return false;
    }


    //cast rays to check if the player is on the ground
    bool IsGrounded()
    {
        Debug.DrawRay(transform.position, -Vector3.up, Color.black);
        if (Physics.Raycast(transform.position, -Vector3.up, 3, LayerMask))
            return true;

        Debug.DrawRay(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up, Color.black);
        if (Physics.Raycast(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up, 3, LayerMask))
            return true;

        Debug.DrawRay(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up, Color.black);
        if (Physics.Raycast(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up, 3, LayerMask))
            return true;

        return false;
    }

    public PlayerIndex GetPlayerIndex()
    {
        return playerIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
      
    }

    public void Respawn()
    {
        speed = 0;
        maxSpeed = InitialMaxSpeed;
    }
}
