using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleToggle : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;

    public void ToggleTrue()
    {
        if(_toggle.isOn == true)
        {
            Debug.Log("Toggle is On");
        }
        else
        {
            Debug.Log("Toggle is Off");
        }
    }
}
