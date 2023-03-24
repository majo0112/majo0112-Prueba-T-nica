using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false; // Desactivar Sprite Rendered de la moneda. 
            gameObject.transform.GetChild(0).gameObject.SetActive(true); //Activar el componente colleted.
            Destroy(gameObject, 0.5f); // Eliminar moneda.
        }

    }
}


