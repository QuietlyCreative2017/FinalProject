using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour
{

    public Animator anim;
    bool falling = true;

    void Awake()
    {
        //anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
        falling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, -Vector3.up, 3, LayerMask.NameToLayer("Ground")))
        {
            anim.SetBool("HasHitFloor", true);
            falling = false;
        }

        if(falling)
        {
            Debug.DrawRay()
            if(!Physics.Raycast(transform.position, -Vector3.up, 3, LayerMask.NameToLayer("Ground")))
            {
                transform.Translate(-Vector3.up * 0.5f);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            anim.SetBool("HasHitFloor", true);
        }
        if (col.gameObject.tag == "Player")
        {
            CharacterControls colControls = col.gameObject.GetComponent<CharacterControls>();
            anim.SetBool("HasHitPlay", true);
            colControls.Slow();
        }
    }
}
