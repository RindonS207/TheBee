using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class spawner : MonoBehaviour
{
    void Start()
    {
        normalTime = upSpeed;
    }

    public Transform dim;
    public Transform shuiguo;
    private float normalTime;
    System.Random rd = new System.Random();
    public float upSpeed = 1;

    void Update()
    {
        int amount = rd.Next(0, 3);
        if(amount == 1 && upSpeed <= 0)
        {
            Instantiate(dim, new Vector3(UnityEngine.Random.Range(-3f, 4f), 6.53f, 0), dim.rotation);
            upSpeed = normalTime;
        }
        else if(amount == 2 && upSpeed <= 0)
        {
            Instantiate(shuiguo, new Vector3(UnityEngine.Random.Range(-3f, 4f), 6.53f, 0), dim.rotation);
            upSpeed = normalTime;
        }
        upSpeed -= Time.deltaTime;
    }
}
