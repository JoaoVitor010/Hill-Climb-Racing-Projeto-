using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirigirCarro : MonoBehaviour
{
    [SerializeField] private Rigidbody2D pneuFrente;
    [SerializeField] private Rigidbody2D pneuTras;
    [SerializeField] private Rigidbody2D carro;
    
    [SerializeField] private float speed = -150f;
    [SerializeField] private float rotationSpeed = -300f;

    private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        pneuFrente.AddTorque(moveInput * speed * Time.fixedDeltaTime);
        pneuTras.AddTorque(moveInput * speed * Time.fixedDeltaTime);
        carro.AddTorque(moveInput * rotationSpeed * Time.fixedDeltaTime);
    }
}
