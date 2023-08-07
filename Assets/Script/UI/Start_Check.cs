using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//スタート状態かどうかを確認するスクリプト
public class Start_Check : MonoBehaviour
{
    public GameObject playerPrefab; //生成するプレイヤーをアタッチ
    public static bool startCheck = false;  //スタート状態か確認する変数
    public GameObject canvas;   //タイトル画面のキャンバスをアタッチ

    //スタートボタンが押されたときの処理
    public void OnClickButton()
    {
        startCheck = true;  //スタート状態を有効化する
        GameObject player = Instantiate(playerPrefab);  //プレイヤーを生成する
        Destroy(canvas);    //タイトル画面を消す
    }
}
