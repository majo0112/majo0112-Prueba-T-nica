using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CasperSn : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    { 
    if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}