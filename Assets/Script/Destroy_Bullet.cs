using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        //弾にぶつかったら消す
        if(other.CompareTag("Delete"))
        {
            Destroy(this.gameObject);
        }
    }
}
