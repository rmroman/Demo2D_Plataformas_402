using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Mtz. Román
 * Mantiene información de la salud del personaje
 */
public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;
    public int monedas = 0;

    public static SaludPersonaje instance;

    // Se llama antes que Start, al inicializar la app
    private void Awake()
    {
        instance = this;
    }
}
