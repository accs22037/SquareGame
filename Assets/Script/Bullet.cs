using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public GameObject bullet;
   public GameObject end;
   [SerializeField] float speed;
   float shot_Timer = 0f;
   public float minTime = 10f;
   public float maxTime = 1f;
   public float interval = 5f;
    void Start()
    {
        speed = 10f; //玉の速度   
    }

    void Update()
    {
        shot_Timer += Time.deltaTime;

        if(shot_Timer >= interval)
        {
            //弾の生成
            GameObject clone = Instantiate(bullet,transform.position,Quaternion.identity);
            //飛んでいく座標
            Vector3 endPos = end.transform.position;
            //向きの生成
            Vector3 shotForward = Vector3.Scale((endPos - transform.position), new Vector3(1,1,0)).normalized;
            //弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
            shot_Timer = 0;
            interval = Random.Range(minTime, maxTime);
        }
        Debug.Log(shot_Timer);
    }
}
