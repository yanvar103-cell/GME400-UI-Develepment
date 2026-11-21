using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Toggle[] _toggles;

    public void Toggle0True()
    {
        if (_toggles[0].isOn == true)
            Debug.Log("Game Difficulty is set Easy!");
    }

    public void Toggle1True()
    {
        if (_toggles[1].isOn == true)
            Debug.Log("Game Difficulty is set Medium!");
    }

    public void Toggle2True()
    {
        if (_toggles[2].isOn == true)
            Debug.Log("Game Difficulty is set Hard!");
    }
}
