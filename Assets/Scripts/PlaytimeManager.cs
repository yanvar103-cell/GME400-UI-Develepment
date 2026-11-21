using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlaytimeManager : MonoBehaviour
{
    [SerializeField] private Toggle[] _toggles;
    [SerializeField] private Sprite[] _pics;
    [SerializeField] private Image _image;
    [SerializeField] private Image _crossMarkImage;
    [SerializeField] private Sprite[] _crossMarkPics;
    [SerializeField] private TMP_Text _textfield;

    private void Start()
    {
        _toggles[2].isOn = true;
        _image.sprite = _pics[2];
        _crossMarkImage.sprite = _crossMarkPics[0];
        _textfield.color = Color.green;
        _textfield.text = "You can hug the dinosaur!";

    }

    public void Toggle0True()
    {
        if(_toggles[0].isOn == true)
        {
            _image.sprite = _pics[0];
            _crossMarkImage.sprite = _crossMarkPics[1];
            _textfield.color = Color.red;
            _textfield.text = "Don't feed the dinosaur!";
        }
    }

    public void Toggle1True()
    {
        if (_toggles[1].isOn == true)
        {
            _image.sprite = _pics[1];
            _crossMarkImage.sprite = _crossMarkPics[1];
            _textfield.color = Color.red;
            _textfield.text = "Don't talk to the dinosaur!";
        }
    }

    public void Toggle2True()
    {
        if (_toggles[2].isOn == true)
        {
            _image.sprite = _pics[2];
            _crossMarkImage.sprite = _crossMarkPics[0];
            _textfield.color = Color.green;
            _textfield.text = "You can hug the dinosaur!";
        }
    }
}
