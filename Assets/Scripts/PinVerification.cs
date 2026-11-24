using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinVerification : MonoBehaviour
{
    [SerializeField] private TMP_InputField _createPin;
    [SerializeField] private TMP_InputField _enterPin;
    [SerializeField] private TMP_Text _debugText;

    private int _pinNumber;
    private int _enteredPin;

    // Start is called before the first frame update
    void Start()
    {
        _debugText.text = "";
    }

    public void CreatePin()
    {
        if(_createPin.text.Length < 4)
        {
            _debugText.text = "Error: it needs at least 4 digits";
            _createPin.text = ""; //set it to empty
        }
        else
        {
            _pinNumber = int.Parse(_createPin.text); //int.Parse turns string to integer tryParse is safer on other cases(returns null instead of error)
            //deactivation/activation must be inside the condition, not add them as a function in editor
            _createPin.gameObject.SetActive(false);
            _enterPin.gameObject.SetActive(true);
            _debugText.text = "";
        }
    }

    public void EnterPin()
    {
        if (_enterPin.text.Length < 4)
            _debugText.text = "Error: it needs at least 4 digits";
        else
        {
            _enteredPin = int.Parse(_enterPin.text);
            if(_pinNumber == _enteredPin)
                _debugText.text = "Correct PIN entered";
            else
            {
                _debugText.text = "PIN is incorrect, try again!";
                _enterPin.text = "";
            }
        }
    }
}