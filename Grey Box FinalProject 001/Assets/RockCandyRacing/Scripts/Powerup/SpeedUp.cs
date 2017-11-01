using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    [Tooltip("Speed increase whilst in zone")]
    public float InitialSpeedAmount;
    [Tooltip("Speed increase as you leave the zone(to shoot out)")]
    public float ExitSpeedAmount;

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
            if (other.gameObject.GetComponent<CharacterControls>().fInput > 0)
            {
                other.gameObject.GetComponent<CharacterControls>().StartCoroutine(other.gameObject.GetComponent<CharacterControls>().speedUp(InitialSpeedAmount));

            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<CharacterControls>().fInput > 0)
            {
                other.gameObject.GetComponent<CharacterControls>().StartCoroutine(other.gameObject.GetComponent<CharacterControls>().speedUp(ExitSpeedAmount));
            }
        }

    }
}
