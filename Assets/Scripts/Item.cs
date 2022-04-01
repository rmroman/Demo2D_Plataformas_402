using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Martínez Román
 * Detecta las colisiones con el personaje
 */
public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject, 0.3f);
            // Cuenta monedas recolectadas
            SaludPersonaje.instance.monedas++;
            HUD.instance.ActualizarContadorMonedas();

            // Efecto de sonido
            efectoMoneda.Play();
        }
    }
}
