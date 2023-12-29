using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitro : MonoBehaviour
{
    public float SpeedIncrease;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Carro"))
        {
            DirigirCarro.instance1.IncreaseSpeed(SpeedIncrease);
            Destroy(gameObject);
        }
    }
}
