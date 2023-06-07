using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2kucuktoplar : MonoBehaviour
{
   public ParticleSystem efekt;
    void Start()
    {
        efekt.Stop();
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="sepetsayi")
        {
            efekt.Play();
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void Update()
    {
        
    }
}
