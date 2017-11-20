using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;
using UnityEngine.UI;

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
    bool StoppedJumping = true;

    public LayerMask LayerMask;
    //////////////Jumping//////////////

    //[Tooltip("Key input type (WASD / Key(arrows)) for debugging without controller")]
    //public string type;
    [Tooltip("Maximum velocity")]
    public float maxSpeed;
    [Tooltip("Maximum speed to get a boost")]
    public float maxBoostSpeed;


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



    float InitialMaxSpeed;

    float lerp = 0.0f;

    public float movementRayLength = 2;
    Vector3 movementPosition;

    public float CameraBoost;
    public float CameraBoostCooldown;
    float camBoostCD;

    public Animator winAnim;

    [Tooltip("How fast the player slows down (multiplier)")]
    public float speedDecrease;

    public LayerMask Ground;
    public float PickupCD;
    [HideInInspector]
    public float PickupCDA;

    public GameObject[] SlowDownParticles;


    public TextMesh UIText;
    string uiTextText;

    public GameObject RocketImage;
    public GameObject TrapImage;

    public AudioManager AudManager;

    public float backwardsSpeedReduction;

    [HideInInspector]
    public bool inZone;

    //speed take two
    public float currentSpeed;
    public float initialSpeed;
    public float maxSpeedTwo;
    public float speedBoostMax;
    public float backwardsReduction;
    public float speedIncreaseTwo;
    public float speedReductionTwo;


    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        AudManager = gameObject.GetComponent<AudioManager>();
    }

    // Use this for initialization
    void Start()
    {
        JumpTimeCounter = JumpTime;
        speed = maxSpeed / 4;
        InitialMaxSpeed = maxSpeed;
        camBoostCD = CameraBoostCooldown;
        PickupCDA = 0;

        //speed take two

        currentSpeed = initialSpeed;

        //end speed take two
    }

    // Update is called once per frame
    void Update()
    {
        camBoostCD -= Time.deltaTime;
        HandleXinput();
        PickupCDA -= Time.deltaTime;

        if (!grounded)
        {
            gameObject.layer = LayerMask.NameToLayer("InAir");
        }
        else
        {
            gameObject.layer = LayerMask.NameToLayer(gameObject.name);
        }


        KeepGrounded();

        if (GetComponent<RocketScript>().rocket)
        {
            RocketImage.SetActive(true);
        }
        if (GetComponent<DroppableScript>().canUse)
        {
            TrapImage.SetActive(true);
        }

        if (!GetComponent<DroppableScript>().canUse && !GetComponent<RocketScript>().rocket)
        {
            TrapImage.SetActive(false);
            RocketImage.SetActive(false);
        }

        if (PickupCDA < 0)
        {
            PickupCDA = 0;
        }

        //if speed is greater than max / 2
        //if (speed > maxSpeed / 2)
        //{
        //    speed -= Time.deltaTime * speedDecrease;
        //}
        //
        //
        //if (speed > maxSpeed)
        //{
        //    if (speed > InitialMaxSpeed / 2)
        //    {
        //        speed -= Time.deltaTime * (speedDecrease * 4);
        //    }
        //}
        //
        //if(speed > maxSpeed * 2)
        //{
        //    speed = maxSpeed * 2;
        //}

        //speed take two

        if (currentSpeed > maxSpeedTwo)
        {
            currentSpeed -= Time.deltaTime * (speedReductionTwo * 2);
        }

        if (currentSpeed > speedBoostMax)
        {
            currentSpeed -= Time.deltaTime * (speedReductionTwo * 10) ;
        }

        //end speed take two

        //if (speed > maxSpeed / 2)
        //{
        //    float difference = maxSpeed - speed;
        //    speed -= (maxSpeed - difference) * Time.deltaTime;
        //
        //}


        //speed end

        grounded = IsGrounded();

        if (Camera.main.WorldToViewportPoint(transform.position).x <= 0.2f)
        {
            if (camBoostCD <= 0 && speed <= InitialMaxSpeed * 2)
            {
                //speedUp(CameraBoost);
                speed *= CameraBoost;
                camBoostCD = CameraBoostCooldown;
            }
        }

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
        if (Time.timeScale != 0)
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
        if (fInput <= 1 && fInput >= -1 && !inZone)
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
            if (speed < maxSpeed / 2)
            {
                //speed up
                speed += Time.deltaTime * 7;
            }

            //speed take two

            if (currentSpeed <= maxSpeedTwo)
            {
                currentSpeed += Time.deltaTime * speedIncreaseTwo;
            }

            //end speed take two
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

            //speed take two

            if (currentSpeed > initialSpeed)
            {
                currentSpeed -= Time.deltaTime * speedReductionTwo;
            }

            //end speed take two
        }

        //jump by pushing A
        if (previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Pressed)
        {
            if (grounded)
            {
                //jump!
                //rb.AddForce(new Vector3(0, m_JumpVel, 0)); 
                rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
                StoppedJumping = false;
                JumpTimeCounter = JumpTime;
                AudManager.PlaySound("Jump_SFX", false, 0.2f, 128);
            }
        }

        //if (!StoppedJumping)
        //{
        //    //and your counter hasn't reached zero...
        //    if (JumpTimeCounter > 0)
        //    {
        //        //keep jumping!
        //        rb.velocity = new Vector3(rb.velocity.x, m_JumpVel, 0);
        //        JumpTimeCounter -= Time.deltaTime;
        //    }
        //}

        //if you have released a and minimum jump is reached
        //or you jump for the full time
        if ((previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Released/* && JumpTimeCounter <= JumpTime - Time.deltaTime*/) || JumpTimeCounter <= 0)
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
        StartCoroutine("Sslow");
        StartCoroutine(Vibrate(1));
        //StopCoroutine("slow");
    }

    public void ControllerVibration()
    {
        GamePad.SetVibration(playerIndex, 0, 0);
    }

    public IEnumerator Vibrate(float a_Vibration)
    {
        GamePad.SetVibration(playerIndex, a_Vibration, a_Vibration);
        yield return new WaitForSecondsRealtime(5);
        GamePad.SetVibration(playerIndex, 0, 0);
    }

    //divide maxSpeed by whatever wait 2 seconds and restore
    IEnumerator Sslow()
    {
        foreach (GameObject GO in SlowDownParticles)
        {
            GO.GetComponent<ParticleSystem>().Play();
        }
        AudManager.PlaySound("Daze_SFX", false, 0.2f, 128);
        speed /= 2;
        yield return new WaitForSeconds(2f);
    }

    //Multiplied max speed by 2 then waits for 2 seconds 
    public IEnumerator speedUp(float a_SpeedIncrease, bool playSound)
    {
        //if (speed <= maxBoostSpeed)
        //{
        //    if (playSound)
        //    {
        //        AudManager.PlaySound("Turbo_Boost_SFX_v2", false, 0.05f, 128);
        //    }
        //    speed *= a_SpeedIncrease;
        //}

        if (currentSpeed <= speedBoostMax)
        {
            if (playSound)
            {
                AudManager.PlaySound("Turbo_Boost_SFX_v2", false, 0.05f, 128);
            }
            currentSpeed *= a_SpeedIncrease;
        }
        yield return new WaitForSeconds(0.5f);
    }

    void KeepGrounded()
    {
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(transform.position + Vector3.up * -1.75f, Vector3.right * movementRayLength, Color.red);
        if (Physics.Raycast(transform.position + Vector3.up * -1.75f, Vector3.right * movementRayLength, out hit, 1, LayerMask.NameToLayer("Ground")))
        {
            gravity = new Vector3(0, -100, 0);
        }
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

        for (int i = 0; i < 2; i++)
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
        if (leastDist.distance != 0 && fInput != 0 && grounded && StoppedJumping)
        {
            //point to move to is now the current position + least distance ray * deltaTime
            return rb.position + Vector3.right * leastDist.distance * Time.deltaTime;
        }
        else
        {
            //else point to move to stays the same
            if (Mathf.Sign(fInput) == 1)
            {
                return rb.position + transform.right * fInput * currentSpeed * Time.fixedDeltaTime;
            }
            else
            {
                return rb.position + transform.right * fInput * (currentSpeed * backwardsSpeedReduction) * Time.fixedDeltaTime;
            }
        }
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
        {
            //if (gameObject.GetComponent<Rigidbody>().velocity.y == 0 || Mathf.Sign(gameObject.GetComponent<Rigidbody>().velocity.y) == -1)
            return true;
        }

        Debug.DrawRay(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up, Color.black);
        if (Physics.Raycast(new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z), -Vector3.up, 3, LayerMask))
        {
            //if (gameObject.GetComponent<Rigidbody>().velocity.y <= 0)
            //if (gameObject.GetComponent<Rigidbody>().velocity.y == 0 || Mathf.Sign(gameObject.GetComponent<Rigidbody>().velocity.y) == -1)
            return true;
        }

        Debug.DrawRay(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up, Color.black);
        if (Physics.Raycast(new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z), -Vector3.up, 3, LayerMask))
        {
            //if (gameObject.GetComponent<Rigidbody>().velocity.y <= 0)
            //if (gameObject.GetComponent<Rigidbody>().velocity.y == 0 || Mathf.Sign(gameObject.GetComponent<Rigidbody>().velocity.y) == -1)
            return true;
        }

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

    public void PlayWinAnimation()
    {
        //if(winAnim.isActiveAndEnabled)
        if (winAnim != null)
        {
            winAnim.Play(0);

        }
    }

    public void RefreshInputState()
    {
        currentState = GamePad.GetState(playerIndex);
    }

    private void OnApplicationQuit()
    {
        GamePad.SetVibration(playerIndex, 0, 0);
    }
}
