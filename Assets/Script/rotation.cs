using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//回転アニメーション用スクリプト
public class rotation : MonoBehaviour
{
    float timer;
    
    //アニメーションの回転設定(インスペクタで設定)
    [SerializeField]private float rotateX = 0;
    [SerializeField]private float rotateY = 0;
    [SerializeField]private float rotateZ = 0;
    void Update()
    {
        //一定時間ごとに回転を行う
        timer += Time.deltaTime;
        if(timer >= 0.1f)
        {
            gameObject.transform.Rotate(new Vector3(rotateX,rotateY,rotateZ));
            timer = 0;
        }
    }
}
