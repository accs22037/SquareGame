using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTimer : MonoBehaviour
{
	private int minute;
	private float seconds;
	//　前のUpdateの時の秒数
	private float oldSeconds;
	//　タイマー表示用テキスト
	private Text bestTimerText;
 
    void Start()
    {
        bestTimerText = GetComponentInChildren<Text> ();
    }
	void Update () {
        if(Timer.minute >= minute && Timer.seconds >= seconds)
        {
            minute = Timer.minute;
            seconds = Timer.seconds;
        }

		bestTimerText.text = "BestTime " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
    }
}

