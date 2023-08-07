using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//カメラを移動させるスクリプト
public class Cam : MonoBehaviour
{
    void Update()
    {
        //transformを取得
        Transform camBack = this.transform;

        //ワールド座標を基準に座標を取得
        Vector3 pos = camBack.position;

        //スタートしたら開始する
        if(Start_Check.startCheck == true)
        {
            if(pos.z >= -120f)  //目標座標
            {
                pos.z -= 0.00556f;
            }
            camBack.position = pos; //座標を反映
        }
        //開始していない場合は固定する
        else
        {
            pos.z = -20;

            camBack.position = pos; //座標を反映
        }
    }
}
