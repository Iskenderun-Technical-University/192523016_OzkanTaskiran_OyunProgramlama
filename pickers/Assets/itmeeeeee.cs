using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itmeeeeee : MonoBehaviour
{

    public Rigidbody rbb;
    public float hiz;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ittmee")
        {
            rbb.velocity = new Vector3(-hiz,0,0);
        }
    }
}
