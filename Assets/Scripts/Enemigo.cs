using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SaludPersonaje.instance.vidas--;
            HUD.instance.ActualizarVidas();

            if (SaludPersonaje.instance.vidas == 0)
            {
                Destroy(collision.gameObject, 0.2f); // Destruye el PERSONAJE
            }
        }
    }
}
