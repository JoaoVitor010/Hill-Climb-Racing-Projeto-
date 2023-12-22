using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoiDistancia : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextoDistancia;
    [SerializeField] private Transform playerTransform;

    private Vector2 posicaoComeco;
    private void Start()
    {
        posicaoComeco = playerTransform.position;
    }
    private void Update()
    {
        Vector2 distancia = (Vector2)playerTransform.position - posicaoComeco;
        distancia.y = 0f;

        if (distancia.x < 0)
        {
            distancia.x = 0;
        }

        TextoDistancia.text = distancia.x.ToString("F0") + "m";
    }
}
