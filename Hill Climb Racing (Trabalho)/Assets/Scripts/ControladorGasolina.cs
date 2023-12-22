using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGasolina : MonoBehaviour
{
    public static ControladorGasolina instance;

    [SerializeField] private Image imageGasolina;
    [SerializeField, Range(0.1f, 5f)] private float gasolinaGastaVelocidade = 1f;
    [SerializeField] private float gasolinaMaxima = 100f;
    [SerializeField] private Gradient gradientGasolina;

    private float combustivelAtual;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        combustivelAtual = gasolinaMaxima;
        UpdateUI();
    }
    
    void Update()
    {
        combustivelAtual -= Time.deltaTime * gasolinaGastaVelocidade;
        UpdateUI();

        if (combustivelAtual <= 0)
        {
            GameManager.instance.GameOver();
        }
    }

    private void UpdateUI()
    {
        imageGasolina.fillAmount = (combustivelAtual / gasolinaMaxima);
        imageGasolina.color = gradientGasolina.Evaluate(imageGasolina.fillAmount);
    }
}
