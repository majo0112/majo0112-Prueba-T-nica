using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LotoSc : MonoBehaviour
{

    [SerializeField] private GameObject efecto;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (ContactPoint2D punto in other.contacts)
            {
                if (punto.normal.y <= -0.9f)
                {
                    other.gameObject.GetComponent<PlayerMove>().Rebote();
                }
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(efecto, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}
