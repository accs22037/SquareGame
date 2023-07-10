using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        //transformを取得
        Transform camBack = this.transform;

        //ワールド座標を基準に座標を取得
        Vector3 pos = camBack.position;

        if(Start_Check.startCheck == true)
        {
            if(pos.z >= -120f)
            {
                pos.z -= 0.00556f;
            }
            camBack.position = pos; //座標を設定
        }
        else
        {
            pos.z = -20;

            camBack.position = pos; //座標を設定
        }
    }
}
