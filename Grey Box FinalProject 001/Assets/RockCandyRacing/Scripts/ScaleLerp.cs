using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScaleLerp : MonoBehaviour
{

    public GameObject uiObj;
    public bool increasing;

    Vector3 scale;
    Vector3 original;

    float lerp;
    public float duration;

    public float sizeToGoTo;

    public EventSystem eSystem;

    float previousTime;
    float currentTime;
    float deltaTime;
    // Use this for initialization
    void Start()
    {
        previousTime = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        uiObj = eSystem.currentSelectedGameObject;
        
        //


        //currentTime = Time.timeSinceLevelLoad;
        //deltaTime = currentTime - previousTime;
        if (Time.deltaTime != 0)
        {
            lerp += Time.deltaTime / duration;
        }
        else
        {
            lerp += deltaTime / duration;
        }
        
        if (uiObj != null)
        {
            if (increasing)
            {
                uiObj.transform.localScale = Vector3.Lerp(uiObj.transform.localScale, new Vector3(sizeToGoTo, sizeToGoTo, sizeToGoTo), Time.unscaledDeltaTime * duration);
            }
            else
            {
                uiObj.transform.localScale = Vector3.Lerp(uiObj.transform.localScale, new Vector3(1, 1, 1), Time.unscaledDeltaTime * duration);
            }
        

            if (uiObj.transform.localScale == new Vector3(sizeToGoTo, sizeToGoTo, sizeToGoTo))
            {
                increasing = false;
                lerp = 0;
            }
            if (uiObj.transform.localScale == new Vector3(1, 1, 1))
            {
                increasing = true;
                lerp = 0;
            }

        }
        previousTime = Time.timeSinceLevelLoad;
    }

    bool isApproximate(float inputA, float inputB, float tollerance)
    {
        return inputA - inputB < tollerance;
    }
}
