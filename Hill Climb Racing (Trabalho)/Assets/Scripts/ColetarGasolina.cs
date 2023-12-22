using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarGasolina : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Carro"))
        {
            ControladorGasolina.instance.MaisGasolina();
            Destroy(gameObject);
        }
    }
}
