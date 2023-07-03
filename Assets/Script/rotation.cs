using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    float timer;
    [SerializeField]private float rotateX = 0;
    [SerializeField]private float rotateY = 0;
    [SerializeField]private float rotateZ = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.1f)
        {
            gameObject.transform.Rotate(new Vector3(rotateX,rotateY,rotateZ));
            timer = 0;
        }
    }
}
