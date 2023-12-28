using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreValue;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Carro"))
        {
            GameController.instance.UpdateScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
