using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//飛んでいった弾を削除するスクリプト
public class Destroy_Bullet : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        //ぶつかったら弾を消す
        if(other.CompareTag("Delete"))
        {
            Destroy(this.gameObject);
        }
    }
}
