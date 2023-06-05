using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silindir : MonoBehaviour
{

    

    void Start()
    {

        
        StartCoroutine(silindirdusme());

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sepetsayi")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;

        }
    }

   
   

    IEnumerator silindirdusme()
    {
        
        yield return new WaitForSeconds(13.5f);
        dusmekontrol();

    }
    public void dusmekontrol()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        
    }
    
}