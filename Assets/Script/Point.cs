using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public static int point; //スコアを計測する変数
    private void OnTriggerEnter2D(Collider2D other) //Playerとの衝突を検知(On Trigger)
    {
            //Playerに触れると消滅し、スコアを追加する
            if (other.CompareTag("Player"))
            {
                Destroy(this.gameObject);
                point++;
                Debug.Log(point); //確認用
            }
    }
}
