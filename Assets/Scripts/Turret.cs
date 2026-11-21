using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _instantiatePoint;
    [SerializeField] private float _speed = 20f;

    public void PressFire()
    {
        GameObject projectile = Instantiate(_projectile, _instantiatePoint.position, _instantiatePoint.rotation);
        projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 500));
    }

    public void PressLeft()
    {
        transform.Rotate(0, 1f * _speed, 0);
    }

    public void PressRight()
    {
        transform.Rotate(0, -1f * _speed, 0);
    }
}
