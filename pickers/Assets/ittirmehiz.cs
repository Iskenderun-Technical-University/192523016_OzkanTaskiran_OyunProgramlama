using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ittirmehiz : MonoBehaviour
{
    public Rigidbody itmekontrol;
    public float itmehiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="itmetetik")
        {
            itmekontrol.velocity = new Vector3(-itmehiz, 0, 0);
        }



        if (other.gameObject.tag=="durma")
        {
            itmekontrol.velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }



        if (other.gameObject.tag == "itmetetik2")
        {
            itmekontrol.velocity = new Vector3(-itmehiz, 0, 0);
            
        }


    }


}
