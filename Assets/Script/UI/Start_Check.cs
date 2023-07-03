using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Check : MonoBehaviour
{
    public GameObject playerPrefab;
    public static bool startCheck = false;
    public void OnClickButton()
    {
        startCheck = true;
        GameObject player = Instantiate(playerPrefab);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
