using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerule : MonoBehaviour
{
    public static bool alive = true;
    //当たり判定の設定(2Dを忘れない!)
    private void OnTriggerEnter2D(Collider2D other)
    {
        //弾にぶつかったら消す
        if(other.CompareTag("Bullet"))
        {
            alive = false;
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        Application.targetFrameRate = 60;
    }
}
