using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollX : MonoBehaviour
{
    public float speedX = -1;

    void Update()
    {
        // ���1
        transform.Translate(speedX * Time.deltaTime, 0, 0);

        //// ���2
        //var pos = transform.position;
        //pos.x += speedX * Time.deltaTime;
        //transform.position = pos;
    }
}
