using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ゲームルール(弾に当たったらゲームオーバー)のスクリプト
public class Gamerule : MonoBehaviour
{
    public static bool alive = true; //生存状態の変数
    private void OnTriggerEnter2D(Collider2D other) //当たり判定の設定(2Dを忘れない!)
    {
        //弾にぶつかったら消す(やられる)
        if(other.CompareTag("Bullet"))
        {
            alive = false;
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        //フレームレートを固定
        Application.targetFrameRate = 60;
    }
}
