using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pervanecoin : MonoBehaviour
{

    public Rigidbody rbb;
    public float rbbhiz;

    void Start()
    {
        
    }

   
    void Update()
    {
        // rotasyon 
        transform.Rotate(new Vector3(0, 1, 0));
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="oyuncu")
        {

        }
    }
}
