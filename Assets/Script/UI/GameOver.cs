using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ゲームオーバー処理
public class GameOver : MonoBehaviour
{
    [SerializeField] Text gameOver; //テキスト
    float gameoverTimer = 0; //タイマー
    public GameObject startCanvas;

    void Update()
    {
        if(Gamerule.alive == false)//生存状態が無くなったとき
        {
            gameOver.text = "GAME OVER"; //テキスト変更
            gameoverTimer += Time.deltaTime; //タイマー進める
        }
        else //それ以外
        {
            gameOver.text = ""; //何も表示しない
        }
        if(gameoverTimer >= 3) //ゲームオーバー後の処理
        {
            Gamerule.alive = true; //生存状態のリセット
            gameoverTimer = 0; //タイマーリセット
            Start_Check.startCheck = false; //スタート状態無効
            Instantiate(startCanvas);
            SceneManager.LoadScene("Main");
        }
    }
}
