using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    void Start()
    {
        this.trans = this.transform;
        ad = this.GetComponent<AudioSource>();
    }

    private Transform trans;
    private AudioSource ad;
    public AudioClip clip;
    public Camera mainCamera;
    public Transform getItemFx;

    void Update()
    {
        this.trans.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "item")
        {
            ad.PlayOneShot(clip);
            Instantiate(getItemFx, other.transform.position,getItemFx.rotation);
        }
    }
}
