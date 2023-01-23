using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public int point;
    public float downSpeed;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed * Time.deltaTime, transform.position.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            
            Destroy(this.gameObject);
            score_text.addScore(this.point);
        }
        if(other.tag == "ground")
        {
            Destroy(this.gameObject);
            score_text.deleteScore(this.point);
        }
    }
}
