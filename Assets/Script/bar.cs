using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//画面外への移動を制限する壁を動かすスクリプト
//カメラと同じ速度で移動する
public class bar : MonoBehaviour
{
    //上下移動かどうかを判定
    public bool upDown = true;
    //プラス(上か右)かどうか判定
    public bool puls = true;

    public static Vector3 pos;
    
    void Update()
    {
        
        //transformを取得
        Transform camBack = this.transform;
        //ワールド座標を基準に座標を取得
        pos = camBack.position;
        //スタート判定を確認
        if(Start_Check.startCheck == true)
        {
            //上の移動
            if(upDown == true && puls == true)
            {
                if(pos.y <= 69f)    //移動目標座標
                {
                    pos.y += 0.0032f;   //1フレームあたりの移動距離
                }
             }

            //下の移動
            else if(upDown == true && puls == false)
            {
                if(pos.y >= -69f)   //移動目標座標
                {
                    pos.y -= 0.00317f;  //1フレームあたりの移動距離
                }
            }

            //右の移動
            else if(upDown == false && puls == true)
            {
                if(pos.x <= 144f)   //移動目標座標
                {
                    pos.x += 0.00573f;  //1フレームあたりの移動距離
                }
            }

            //左の移動
            else if (upDown == false && puls == false)
            {   
                if(pos.x >= -144f)  //移動目標座標
                {
                    pos.x -= 0.00573f;  //1フレームあたりの移動距離
                }
            }

            camBack.position = pos; //座標を反映
        }
        //スタートしていない時(タイトル画面)の処理
        else
        {
            //上の処理
            if(upDown == true && puls == true)
            {
                pos.y = 12;     //位置を固定する
            }
            //下の処理
            else if(upDown == true && puls == false)
            {
                pos.y = -12;    //位置を固定する   
            }
            //右の処理
            else if(upDown == false && puls == true)
            {
                
                pos.x = 20.5f;  //位置を固定する

            }
            //左の処理
            else if (upDown == false && puls == false)
            {   
                pos.x = -20.5f; //位置を固定する
            }

            camBack.position = pos; //座標を反映
        }
        Debug.Log(camBack.position.y);
    }
}
