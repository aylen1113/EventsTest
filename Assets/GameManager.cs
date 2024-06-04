using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text monedaText;
    private int Contador;

    void MonedaText()
    {
        Contador++;
        monedaText.text = "Monedas: " + Contador;

    }

    private void OnEnable()
    {
        Moneda.monedaEvent += MonedaText;
    }

    private void OnDisable()
    {
        Moneda.monedaEvent -= MonedaText;
    }
}
