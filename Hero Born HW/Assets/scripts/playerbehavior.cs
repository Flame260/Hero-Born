using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float Rotatespeed = 75f;

    private Rigidbody _rb;
    private float _vInput;
    private float _hInput;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;

        _hInput = Input.GetAxis("Horizontal") * Rotatespeed;

        /*
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);

        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot =Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
