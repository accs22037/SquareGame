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
        if(pos.z >= -40f)
        {
            pos.z -= 0.01f;
        }

        camBack.position = pos; //座標を設定
    }
}
