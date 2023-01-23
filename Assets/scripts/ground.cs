using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    void Start()
    {
        ad = this.GetComponent<AudioSource>();
    }
    private AudioSource ad;
    public AudioClip clip;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "item")
        {
            ad.PlayOneShot(clip);
        }
    }
}
