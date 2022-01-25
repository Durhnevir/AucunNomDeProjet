using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChase : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.1f;
    private Vector3 _mousePositon;
    private Vector3 _position = new Vector3(0,0,0);
    private Rigidbody _rb;
    private RaycastHit _hit;
    private Ray _ray;
    float zAxis = 2f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    private void Update()
    {
        if (Physics.Raycast(_ray, out _hit))
        {
            Debug.DrawLine(transform.position, _hit.point);
        }
        _mousePositon = Input.mousePosition;
        _mousePositon = Camera.main.ViewportToScreenPoint(_mousePositon);
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(_mousePositon);
    }
}
