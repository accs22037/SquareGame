using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] Text gameOver;
    float gameoverTimer = 0;
    void Update()
    {
        if(Gamerule.alive == false)
        {
            gameOver.text = "GAME OVER";
            gameoverTimer += Time.deltaTime;
        }
        else
        {
            gameOver.text = "";
        }
        if(gameoverTimer >= 3)
        {
            Gamerule.alive = true;
            gameoverTimer = 0;
            Start_Check.startCheck = false;
        }
    }
}
