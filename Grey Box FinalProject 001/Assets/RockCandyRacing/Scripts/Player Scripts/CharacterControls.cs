using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;

public class CharacterControls : MonoBehaviour
{

    float h;
    Vector3 direction;
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
    int distToGround;

    //XINPUT REQS
    [Tooltip("Player #, needed for input controls")]
    public PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;


    Vector3 forceForward;
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    {
        JumpTimeCounter = JumpTime;
    }

    // Update is called once per frame
    void Update()
    {
        HandleXinput();

        grounded = IsGrounded();

        //transform.Translate(direction);
        if (grounded)
        {
            gravity = new Vector3(0, gravityforce, 0);
            m_JumpVel = JumpVel;
            //JumpTimeCounter = JumpTime;
        }
        //Debug.Log(gravity.y);
    }

    void HandleXinput()
    {
        currentState = GamePad.GetState(playerIndex);

        //if controller index isn't connected
        if (!currentState.IsConnected)
        {
            //break out of function
            return;
        }

        //get left stick for movement
        if (IsStuckLeft())
        {
            if(Mathf.Sign(currentState.ThumbSticks.Left.X) == -1)
            {
                h = currentState.ThumbSticks.Left.X;
            }   
        }
        else if(IsStuckRight())
        {
            if (Mathf.Sign(currentState.ThumbSticks.Left.X) == 1)
            {
                h = currentState.ThumbSticks.Left.X;
            }
        }
        else
        {
            h = currentState.ThumbSticks.Left.X;
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
        if ((previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Released && JumpTimeCounter <= JumpTime / 1.5f) || JumpTimeCounter <= 0)
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
        //h = currentState.ThumbSticks.Left.X;
        //h = Input.GetAxis("Horizontal" + type);
        //direction = new Vector3(h, 0, 0);
        forceForward = new Vector3(h, 0, 0);
        //direction.x *= speed;
        forceForward.x *= speed;

        
        //movement force
        if (rb.velocity.magnitude <= maxSpeed)
        {
            rb.AddForce(forceForward);
        }


        ////////////////////////Start Gravity////////////////////////
        if ((!grounded || rb.velocity.y > 0 || rb.velocity.y < 0) /*&& StoppedJumping*/)
        {
            // if(gravity.y >= -200)
            if (gravity.y >= -100)
            {
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

        //if you press down the mouse button...
        //if (Input.GetAxis("Vertical" + type) > 0)
        //{
        //    //if (XCI.GetButton(XboxButton.A))
        //    //{
        //    //and you are on the ground...
        //    if (grounded)
        //    {
        //        //jump!
        //        rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
        //        StoppedJumping = false;
        //        JumpTimeCounter = JumpTime;
        //    }
        //
        //    //}
        //}
        //
        ////if you keep holding down the mouse button...
        //if (/*(Input.GetAxis("Vertical" + type) > 0) &&*/ !StoppedJumping)
        //{
        //    //if (XCI.GetButton(XboxButton.A) && !StoppedJumping)
        //    //{
        //    //and your counter hasn't reached zero...
        //    if (JumpTimeCounter > 0)
        //    {
        //        //keep jumping!
        //        rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
        //        JumpTimeCounter -= Time.deltaTime;
        //    }
        //    //}
        //}
        //
        ////if you stop holding down the mouse button...
        //if ((Input.GetAxis("Vertical" + type) <= 0 && JumpTimeCounter <= JumpTime / 1.5f) || JumpTimeCounter <= 0)
        //{
        //    //if (XCI.GetButtonUp(XboxButton.A) && !StoppedJumping)
        //    // {
        //    //stop jumping and set counter to zero.
        //    JumpTimeCounter = 0;
        //    StoppedJumping = true;
        //    //}
        //}
    }

    public void Slow()
    {
        StartCoroutine("slow");
        //StopCoroutine("slow");
    }

    IEnumerator slow()
    {
        speed /= 2.0f;
        yield return new WaitForSeconds(2f);
        speed *= 2.0f;
    }

    IEnumerator speedUp()
    {
        speed *= 2.0f;
        yield return new WaitForSeconds(2f);
        speed /= 2.0f;
    }

    IEnumerator stun()
    {
        yield return new WaitForSeconds(5f);
    }

    bool IsStuckLeft()
    {
        Debug.DrawRay(transform.position, new Vector3(0.6f, 0, 0));
        if (Physics.Raycast(transform.position, Vector3.right, 0.6f, 1))
        {
            h = 0;
            return true;
        }
        
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), new Vector3(0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Vector3.right, 0.6f, 1))
        {
            h = 0;
            return true;
        }
        
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), new Vector3(0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.right, 0.6f, 1))
        {
            h = 0;
            return true;
        }

        else return false;
    }

    bool IsStuckRight()
    {
        Debug.DrawRay(transform.position, new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(transform.position, Vector3.left, 0.6f, 1))
        {
            h = 0;
            return true;
        }
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Vector3.left, 0.6f, 1))
        {
            h = 0;
            return true;
        }
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), new Vector3(-0.6f, 0, 0));
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.left, 0.6f, 1))
        {
            h = 0;
            return true;
        }

        else return false;
    }

    bool IsGrounded()
    {
        //Debug.DrawRay(transform.position, -Vector3.up);
        if (Physics.Raycast(transform.position, -Vector3.up, 1))
            return true;

        //Debug.DrawRay(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up);
        if (Physics.Raycast(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up, 1))
            return true;

        //Debug.DrawRay(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up);
        if (Physics.Raycast(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up, 1))
            return true;

        return false;
    }

    public PlayerIndex GetPlayerIndex()
    {
        return playerIndex;
    }
}
