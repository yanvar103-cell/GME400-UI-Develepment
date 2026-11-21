using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _healthValuetxt;
    [SerializeField] private int _health;

    void Start()
    {
        _health = 100;
        _slider.value = _health;
        _healthValuetxt.text = _health.ToString();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if (_health <= 0) return;
            _health -= 20;
            _slider.value = _health;
            _healthValuetxt.text = _health.ToString();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_health >= 100) return;
            _health += 20;
            _slider.value = _health;
            _healthValuetxt.text = _health.ToString();
        }
    }
}
