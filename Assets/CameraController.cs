using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 1.0f;

    private Vector3 _movement = Vector3.zero;
    private Vector3 _rotationInput = Vector3.zero;

    private void Start()
    {
    }

    private void Update()
    {
        _rotationInput.y = Input.GetAxis("Horizontal");
        _rotationInput.x = Input.GetAxis("Vertical");

        _rotationInput = Vector3.ClampMagnitude(_rotationInput, 1.0f);
    }

    private void LateUpdate()
    {
        //_movement.x = Input.GetAxis("Horizontal");
        //_movement.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftControl))
        {
            _movement.y = -1;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            _movement.y = 1;
        }
        else
        {
            _movement.y = 0;
        }

        transform.Translate(_movement * Time.deltaTime);

        transform.Rotate(_rotationInput * speed * Time.deltaTime);
    }

}
