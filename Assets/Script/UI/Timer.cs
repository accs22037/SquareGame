using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//タイマーを表示するスクリプト
public class Timer : MonoBehaviour
{
	public static int minute;
	public static float seconds;
	private float oldSeconds;	//前のUpdateの時の秒数
	private Text timerText;		//タイマー表示用テキスト
 
	void Start () {
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text> ();
	}
 
	void Update () {
		//スタート状態かつ生存状態の時のみ時間が更新されるようにする
        if(Start_Check.startCheck == true && Gamerule.alive == true)
        {
		    seconds += Time.deltaTime;
			//分の設定
		    if(seconds >= 60f) {
		    	minute++;
		    	seconds = seconds - 60;
		    }
		    //テキストを更新
		    if((int)seconds != (int)oldSeconds) {
		    	timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
		    }
		    oldSeconds = seconds;
        }
		//タイトル画面では非表示にする
        else if(Start_Check.startCheck == false)
        {
            timerText.text = "";
        }
	}
}

