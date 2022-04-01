using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*
* Autor: Roberto Mtz. Román
* Manipular las imágenes de vida para que representen la salud del prsonaje
*/
public class HUD : MonoBehaviour
{
    public static HUD instance;

    public Image imagen1;
    public Image imagen2;
    public Image imagen3;

    public TextMeshProUGUI txtMonedas;

    private void Awake()
    {
        instance = this;
    }

    // Debe conectarse al botón Reanudar
    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }

    // Refresca las 'vidas' (imágenes de corazón)
    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        switch(vidas)
        {
            case 2:
                imagen3.enabled = false;
                break;
            case 1:
                imagen2.enabled = false;
                break;
            case 0:
                imagen1.enabled = false;
                break;
        }
    }

    public void ActualizarContadorMonedas()
    {
        int monedas = SaludPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }
}
