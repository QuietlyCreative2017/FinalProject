using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScaleLerp : MonoBehaviour {

    public GameObject uiObj;
    public float sizeIncrease;
    public bool increasing;

    Vector3 scale;
    Vector3 original;

    float lerp;
    public float duration = 4.0f;

    public EventSystem eSystem;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        lerp += Time.deltaTime / duration;
        uiObj = eSystem.currentSelectedGameObject;

		if(increasing)
        {
            uiObj.transform.localScale = Vector3.Lerp(uiObj.transform.localScale, new Vector3(2, 2, 2), lerp);
        }
        else
        {
            uiObj.transform.localScale = Vector3.Lerp(uiObj.transform.localScale, new Vector3(1, 1, 1), lerp);
        }

        if (uiObj.transform.localScale == new Vector3(2, 2, 2))
        {
            increasing = false;
            lerp = 0;
        }
        if(uiObj.transform.localScale == new Vector3(1, 1, 1))
        {
            increasing = true;
            lerp = 0;
        }
	}
}
