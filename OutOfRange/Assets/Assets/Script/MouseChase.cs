using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChase : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.1f;
    private Vector3 _mousePositon;
    private Rigidbody _rb;
    private Ray _ray;
    RaycastHit _hit;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {


        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(_ray, out _hit))
        {
            _rb.constraints = RigidbodyConstraints.None;
            Vector3 dir = _hit.point - transform.position;
            dir.y = 0;
            transform.forward = dir.normalized;
            transform.Translate(dir * Time.deltaTime * _moveSpeed, Space.World);

        }
        else
        {
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }

    }
}
