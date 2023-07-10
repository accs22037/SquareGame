using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//弾を発射するスクリプト
public class Bullet : MonoBehaviour
{
    //弾のオブジェクトをアタッチする
   public GameObject bullet;
   //弾が消失するオブジェクトをアタッチする
   public GameObject end;
   //弾のスピード
   [SerializeField] float speed = 10;
   //弾を発射するまでの時間？
   float shot_Timer = 0f;
   //弾の発射間隔の最短時間
   public float minTime = 10f;
   //弾の発射間隔の最長時間
   public float maxTime = 20f;
   //弾の発射間隔
   public float interval = 5f;
    void Start()
    {
        //初回の発射間隔
        interval = Random.Range(1, 20);
    }

    void Update()
    {
        ///スタート判定を確認
        if(Start_Check.startCheck == true)
        {
            shot_Timer += Time.deltaTime;

            if(Gamerule.alive == true && shot_Timer >= interval)
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
        }
    }
}
