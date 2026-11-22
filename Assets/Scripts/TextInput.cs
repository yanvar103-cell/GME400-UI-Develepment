using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInput : MonoBehaviour
{
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private TMP_Text _commentText;

    void Start()
    {
        _commentText.text = "Type something...";
    }

   public void InputFieldTyping()
    {
        _commentText.text = "Typing ...";
    }

    public void InputFieldEntered()
    {
        _commentText.text = $"You entered {_input.text}. Thank you!";
    }
}
