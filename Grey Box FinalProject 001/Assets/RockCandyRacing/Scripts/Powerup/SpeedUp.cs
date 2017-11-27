using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    [Tooltip("Speed increase whilst in zone")]
    public float BoostAmount;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterControls colControls = other.gameObject.GetComponent<CharacterControls>();
            colControls.StartCoroutine(colControls.speedUp(BoostAmount, true));

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterControls colControls = other.gameObject.GetComponent<CharacterControls>();
            colControls.inZone = false;
        }
    
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CharacterControls colControls = col.gameObject.GetComponent<CharacterControls>();
            colControls.fInput = 1;
            colControls.inZone = true;
        }
    }
}
