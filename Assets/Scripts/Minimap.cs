using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Image _enemyPos;
    [SerializeField] private Image _mapPos;

    private void Update()
    {
        _mapPos.rectTransform.localPosition = -1f* new Vector3(_player.transform.position.x, _player.transform.position.z, 0); //multiply -1f if it swapped.
        _enemyPos.rectTransform.localPosition = new Vector3(_enemy.transform.position.x, _enemy.transform.position.z, 0);
    }
}
