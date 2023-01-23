using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        amin = this.GetComponent<Animator>();
        info = amin.GetCurrentAnimatorStateInfo(0);
    }
    private AnimatorStateInfo info;
    private Animator amin;
    // Update is called once per frame
    void Update()
    {
        
        if (info.normalizedTime >= 1.0f)
        {
            Destroy(this.gameObject);
        }
        info = amin.GetCurrentAnimatorStateInfo(0);
    }
}
