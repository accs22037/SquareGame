using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//プレイヤー移動に関するスクリプト
public class Player : MonoBehaviour
{
    [SerializeField]float nomalSpeed = 10.0f; //プレイヤーの通常スピード
    [SerializeField]float slowSpeed = 5f;   //プレイヤーのスロースピード
    float gameSpeed;    //ゲーム中のプレイヤーのスピード

    void Start() 
    {
        gameSpeed = nomalSpeed; //ゲームスピードを通常スピードにする
    }
    void Update()
    {
        //Wキーか上矢印キーを押すと上に進む
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            //forward=前進(上)
            transform.position += gameSpeed * transform.up * Time.deltaTime;
        }
        //Sキーか下矢印キーを押すと下に進む
        if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= gameSpeed * transform.up * Time.deltaTime;
        }
        //Dキーか右矢印キーを押すと右に進む
        if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += gameSpeed * transform.right * Time.deltaTime;
        }
        //Aキーか左矢印キーを押すと左に進む
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= gameSpeed * transform.right * Time.deltaTime;
        }
        //Shiftキーを押すとスロースピードになる
        if (Input.GetKeyDown(KeyCode.LeftShift)||Input.GetKeyDown(KeyCode.RightShift))
        {
            gameSpeed = slowSpeed;
        }
        //Shiftキーが離されると通常スピードに戻る
        if(Input.GetKeyUp(KeyCode.LeftShift)||Input.GetKeyUp(KeyCode.RightShift))
        {
            gameSpeed = nomalSpeed;
        }
        //生存状態がfalseになるとオブジェクトを削除する(ゲームオーバー)
        if(Gamerule.alive == false)
        {
            Destroy(this.gameObject);
        }
    }
}
