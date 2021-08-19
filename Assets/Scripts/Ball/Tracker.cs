using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _centeringSpeed;
    [SerializeField] private float _xAxisIndent;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_ball.transform.position.x - _xAxisIndent, transform.position.y, transform.position.z), _centeringSpeed);
    }
}