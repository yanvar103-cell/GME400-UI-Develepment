using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Account : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuGroups;
    [SerializeField] private TMP_InputField[] _userInputFields;
    [SerializeField] private TMP_Text _debugText;
    private string _username;
    private string _password;

    void Start()
    {
        OpenLoginMenu("");
    }

    public void CreateAccount() //attach to Create btn
    {
        if (_userInputFields[2].text.Length < 4 && _userInputFields[3].text.Length < 4)
        {
            _debugText.text = "Your username and password must be at least 4 digits";
            _userInputFields[2].text = "";
            _userInputFields[3].text = "";
            return;
        }
        else if(_userInputFields[2].text == _username && _userInputFields[3].text == _password)
        {
            _debugText.text = "You already have this account!";
            _userInputFields[2].text = "";
            _userInputFields[3].text = "";
            return;
        }
        else
        {
            _username = _userInputFields[2].text;
            _password = _userInputFields[3].text;
            _debugText.text = "Account created successfully!";
            Debug.Log($"username: {_username} password: {_password}");
            _userInputFields[2].text = "";
            _userInputFields[3].text = "";

            OpenLoginMenu(_debugText.text);
        }
    }

    public void Login() //attach to Login btn
    {
        if(_userInputFields[0].text == _username && _userInputFields[1].text == _password)
        {
            _debugText.text = "You have successfully logged in!";
            _userInputFields[0].text = "";
            _userInputFields[1].text = "";
        }
        else
        {
            _debugText.text = "Inserted username or password is incorrect!";
            _userInputFields[0].text = "";
            _userInputFields[1].text = "";
        }
    }

    public void OpenCreateMenu() //attach to CreateAccount btn
    {
        _menuGroups[0].SetActive(false);
        _menuGroups[1].SetActive(true);

        for (int i = 0; i < _userInputFields.Length; i++)
            _userInputFields[i].text = "";

        _debugText.text = "Create a new account!";
    }

    public void OpenLoginMenu(string afterCreationLog) //attach to Cancel btn
    {
        _menuGroups[1].SetActive(false);
        _menuGroups[0].SetActive(true);
        
        for(int i=0; i<_userInputFields.Length; i++)
            _userInputFields[i].text = "";

        _debugText.text = afterCreationLog + "Insert your username and password!";
    }
}
