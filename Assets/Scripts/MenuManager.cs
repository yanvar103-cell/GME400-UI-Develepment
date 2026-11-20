using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _subMenu1;
    [SerializeField] private Button _button1; //first selected button in submenu1
    
    void Start()
    {
        _mainMenu.SetActive(true);
        _subMenu1.SetActive(false);
    }

    public void ButtonPressed()
    {
        _mainMenu.SetActive(false);
        _subMenu1.SetActive(true);
        _button1.Select();
    }
}
