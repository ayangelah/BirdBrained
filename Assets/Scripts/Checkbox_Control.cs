using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox_Control : MonoBehaviour
{
    public Toggle partToggle;
    public Toggle[] checkbox_toggles;

    private void Start()
    {
        partToggle = gameObject.GetComponent<Toggle>();
        checkbox_toggles = GetComponentsInChildren<Toggle>();
        partToggle.onValueChanged.AddListener(delegate {
            CheckStateChildren();
        });
    }


void CheckStateChildren()
    {
        if (!partToggle.isOn)
        {
            for (int i = 0; i < checkbox_toggles.Length; i++)
            {
                checkbox_toggles[i].isOn = false;
            }
        }
        else
        {
            for (int i = 0; i < checkbox_toggles.Length; i++)
            {
               checkbox_toggles[i].isOn = true;
            }
        }
    }

}
