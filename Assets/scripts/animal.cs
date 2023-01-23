using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{
    void Start()
    {
        startPoint = transform.position;
        finalPoint = this.moveTOpoint;
    }

    private Vector3 startPoint;
    private Vector3 finalPoint;
    public Vector3 moveTOpoint;
    public float speed;
    public int sco = 3;

    void Update()
    {
        if(transform.position.x == startPoint.x)
        {
            finalPoint = moveTOpoint;
            this.transform.localScale = new Vector3(-sco, 3, 1);
        }
        if(transform.position.x == moveTOpoint.x)
        {
            finalPoint = startPoint;
            this.transform.localScale = new Vector3(sco, 3, 1);
        }
        transform.position = Vector3.MoveTowards(transform.position, finalPoint, speed * Time.deltaTime);
    }
}
