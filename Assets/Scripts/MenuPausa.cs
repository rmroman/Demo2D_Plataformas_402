using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Mtz. Román
 * El comportamiento del menú pausa. Pausar y reanudar
 */
public class MenuPausa : MonoBehaviour
{
    [SerializeField] // Para accederlo desde Unity
    private GameObject panelPausa;
    public bool estaPausado = false;

    public static MenuPausa instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }

    }
}
