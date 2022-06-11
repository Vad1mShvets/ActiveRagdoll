using System.Collections.Generic;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] float _maxY = 5f;

    private List<Vector3> _flyPoints;

    private void Update()
    {
        Vector3 direction = _target.position - transform.position;


    }
}
