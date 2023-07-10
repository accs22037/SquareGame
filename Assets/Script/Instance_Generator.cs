using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ジェネレーターを生成する
public class Instance_Generator : MonoBehaviour
{
    int ax = 123;
    int ay = 71;
    int bx = 126;
    int by = 69;
    public GameObject Top;
    public GameObject Under;
    public GameObject Left;
    public GameObject Right;
    void Start()
    {
        //上
        for(var i = -ax; i <= ax; i = i + 3)
        {
            GameObject Generator = Instantiate(Top, new Vector3(i, ay, 0), Quaternion.identity);
        }
        //下
        for(var i = -ax; i <= ax; i = i + 3)
        {
            GameObject Generator = Instantiate(Under, new Vector3(i, -ay, 0), Quaternion.identity);
        }
        //左
        for(var i = -by; i <= by; i = i + 3)
        {
            GameObject Generator = Instantiate(Left, new Vector3(bx, i, 0), Quaternion.identity);
        }
        //右
        for(var i = -by; i <= by; i = i + 3)
        {
            GameObject Generator = Instantiate(Right, new Vector3(-bx, i, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
