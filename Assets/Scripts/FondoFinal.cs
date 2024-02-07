using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Data;

public class FondoFinal : MonoBehaviour
{
    public SpriteRenderer spriteredererFondo;
    public Text Winer;

    void Start()
    {
        spriteredererFondo = GetComponent<SpriteRenderer>();
        Winer.enabled = false;
    }

    void Update()
    {
        if (TimeController.finPartido)
        {
            spriteredererFondo.sortingOrder = 0;
            Winer.enabled = true;

            if (GoalPlayer1.score1 > GoalPlayer2.score2)
            {
                Winer.text = "GANADOR " + " PLAYER 1";
            }
            else if (GoalPlayer1.score1 < GoalPlayer2.score2)
            {
                Winer.text = "GANADOR " + " PLAYER 2";
            }
            else
            {
                //Empate
                Winer.text = "EMPATE";
            }
        }
    }
}
