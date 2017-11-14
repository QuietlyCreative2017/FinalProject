using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour
{

    public Animator anim;

    void Awake()
    {
        //anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            anim.SetBool("HasHitFloor", true);
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        if (col.gameObject.tag == "Player")
        {
            CharacterControls colControls = col.gameObject.GetComponent<CharacterControls>();
            anim.SetBool("HasHitPlay", true);
            colControls.Slow();
            StartCoroutine(WaitAndDestroy());

        }
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }
}
