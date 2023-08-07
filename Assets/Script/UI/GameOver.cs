using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ゲームオーバー処理のスクリプト
public class GameOver : MonoBehaviour
{
    [SerializeField] Text gameOver; //テキスト
    float gameoverTimer = 0; //タイマー

    void Update()
    {
        //生存状態が無くなったときの処理
        if(Gamerule.alive == false)
        {
            gameOver.text = "GAME OVER"; //テキスト変更
            gameoverTimer += Time.deltaTime; //タイマー進める
        }
        else
        {
            gameOver.text = ""; //何も表示しない
        }
         //ゲームオーバー後の処理(リセットとタイトル画面移動)
        if(gameoverTimer >= 3)
        {
            Gamerule.alive = true;  //生存状態のリセット
            gameoverTimer = 0;      //タイマーリセット
            Start_Check.startCheck = false; //スタート状態無効
            SceneManager.LoadScene("Main"); //シーンを再ロード
        }
    }
}
