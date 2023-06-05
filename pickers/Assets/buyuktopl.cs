using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyuktopl : MonoBehaviour
{

    public Rigidbody topkontrol;
    public float tophiz;

   
    void Start()
    {
       
    }

   
    void Update()
    {
        topkontrol.velocity = new Vector3(tophiz,0, 0);
    }

    public Transform kucuktop , buyuktop;
    
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "oyuncu")
        {

            

         

            Destroy(gameObject);
            
            //gameObject.SetActive(false);
            // InvokeRepeating("spawn",0f,0f);
            spawn();
            
        }
    }
   
    
    public void spawn()
    {
        for (int i = 1 ; i < 9; i++)
        {
            Instantiate(kucuktop, buyuktop.position + Random.insideUnitSphere * 3, Quaternion.identity);
        }
        
        
        
    }
}
