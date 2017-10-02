using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;

public class CharacterControls : MonoBehaviour
{

    float h;
    float v;
    Vector3 direction;
    public float speed;

    //JUMP STUFF
    public bool grounded;
    [Tooltip("How fast the player jumps")]

    //////////////Jumping//////////////
    public float JumpVel;
    [Tooltip("Max jump time (for setting a maximum jump height)")]
    public float JumpTime;
    [Tooltip("Tracks how long you've been jumping")]
    float JumpTimeCounter;
    public bool StoppedJumping;
    //////////////Jumping//////////////
    [Tooltip("Key input type (WASD / Key(arrows))")]
    public string type;
    public float maxSpeed;
    public int playerNumber;

    public Transform Ground;

    Rigidbody rb;
    public float gravityforce;
    public Vector3 gravity;
    public float m_JumpVel;

    int distToGround;

    public PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;


    public Vector3 forceForward;
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
    }

    void HandleXinput()
    {
        currentState = GamePad.GetState(playerIndex);

        if (!currentState.IsConnected)
        {
            return;
        }

        
        h = currentState.ThumbSticks.Left.X;

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

        if ((previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Released && JumpTimeCounter <= JumpTime / 1.5f) || JumpTimeCounter <= 0)
        {
            JumpTimeCounter = 0;
            StoppedJumping = true;
        }


        previousState = currentState;
    }


    //Uses collision events and calculates if your object is inside a different one
    //handy for making sure you dont go inside other things
    private void FixedUpdate()
    {
        //h = Input.GetAxis("Horizontal" + type);
        //direction = new Vector3(h, 0, 0);
        forceForward = new Vector3(h, 0, 0);
        //direction.x *= speed;
        forceForward.x *= speed;

        //movement force
        if (rb.velocity.x <= maxSpeed && rb.velocity.x >= -maxSpeed)
        {
            rb.AddForce(forceForward);
        }


        ////////////////////////Start Gravity////////////////////////
        if ((!grounded || rb.velocity.y > 0 || rb.velocity.y < 0) && StoppedJumping)
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

    bool IsStuck()
    {
        return Physics.Raycast(transform.position, Vector3.right, 1, 1);
    }

    bool IsGrounded()
    {
        if (Physics.Raycast(transform.position, -Vector3.up, 1))
            return true;

        if (Physics.Raycast(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), -Vector3.up, 1))
            return true;

        if (Physics.Raycast(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), -Vector3.up, 1))
            return true;

        return false;
    }
}
