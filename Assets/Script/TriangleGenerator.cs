using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleGenerator : MonoBehaviour
{
    public GameObject triPrefab; //三角オブジェクト
    float sX = 205.f;
    float sY = 12f;
    float time;     //経過時間
    float interval; //スポーン間隔
    public float minTime = 3f; //間隔の最小時間
    public float maxTime  = 10f; //間隔の最大時間

    void Start()
    {
        //間隔設定(初期)
        interval = GetRandomTime();
    }

    void Update()
    {
        //生きてる時のみ処理
        if(Start_Check.startCheck == true)
        {
            //時間経過を進める
            time += Time.deltaTime;
        }
        
        if(time > interval)
        {
            //座標の取得(スクリプトbarと同じ処理)
            if(sY >= -67f)   //移動目標座標
                {
                    sY -= 0.00317f;  //1フレームあたりの移動距離
                    float spawnY = Random.Range(sY*-1,sY);
                }
            if(sX <= 142f)   //移動目標座標
                {
                    sX += 0.00573f;  //1フレームあたりの移動距離
                    float spawnX = Random.Range(sX*-1,sX);
                }
            
            //タイマーリセット
            time = 0f;
            //インスタンス化
            GameObject triangle = Instantiate(triPrefab);
            //座標の設定
            triangle.transform.position = new Vector3(spawnX,spawnY,0);
            //次の間隔の設定
            interval = GetRandomTime();
        }
        //初期化
        if(Start_Check.startCheck == false)
        {
            spawnPos = new Vector3(20.5f,12f,0);
        }
    }

    //ランダムな時間を生成する(戻り値)
    private float GetRandomTime()
    {
        return Random.Range(minTime,maxTime);
    }
}
