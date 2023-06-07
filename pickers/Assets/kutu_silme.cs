using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutu_silme : MonoBehaviour
{
    [SerializeField] Rigidbody[] rbs = new Rigidbody[0];
    [SerializeField] Collider[] trg = new Collider[0];

    
    
    void Start()
    {
        Invoke("kutudusme",2f);
        Invoke("saniye",1.2f);
        //Invoke("topdüþme",3.8f);
    }

    void kutudusme()
    {
        for (int i = 0; i < trg.Length; i++)
        {
            trg[i].isTrigger = true;
        }
    }


    void saniye()
    {
        for (int i = 0; i < rbs.Length; i++)
        {
            rbs[i].isKinematic = false;
        }
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="zemin")
        {
            
        }
    }



    void Update()
    {

        

        

    }
}
