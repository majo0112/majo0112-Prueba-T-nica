using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;

    public Text textoScore;

    Dictionary<int, bool> MonedaRecolectada = new Dictionary<int, bool>();

    void Start()
    {

        textoScore.text = "COIN " + score;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            int CoinID = other.gameObject.GetInstanceID();
            if (MonedaRecolectada.ContainsKey(CoinID) && MonedaRecolectada[CoinID])
            {
                return;
            }
            MonedaRecolectada[CoinID] = true;
            score++;
            textoScore.text = "SCORE: " + score;
        }
    }

}


