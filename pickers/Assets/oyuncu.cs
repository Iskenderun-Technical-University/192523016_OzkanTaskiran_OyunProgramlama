using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu : MonoBehaviour
{
    private const int V = 0;

    //saðsol

    public Rigidbody oyuncurgb;
    Vector3 fark;
    Vector3 pozisyon;
    
    public float farehiz;
    float sinirZ = -15f;
    float sinirz = 14f;

    //hareket

    public Rigidbody kuvvet;
    public float kuvvethiz;

    bool kontrol = true;

    void Start()
    {
        
    }

    
    void Update()
    {

        
        if (kontrol)
        {

            kuvvet.velocity = new Vector3(-kuvvethiz, 0, 0);

            if (Input.GetMouseButtonDown(0))
            {
                pozisyon = Input.mousePosition;

            }

            if (Input.GetMouseButton(0))
            {

                fark = Input.mousePosition - pozisyon;

                oyuncurgb.velocity = new Vector3(kuvvet.velocity.x, 0, (fark.x / Screen.width) * farehiz);

                pozisyon = Input.mousePosition;
            }

            else
            {
                oyuncurgb.velocity = new Vector3(oyuncurgb.velocity.x, 0, 0);
            }

            if (transform.position.z <= sinirZ)
            {
                transform.position = new Vector3(transform.position.x, 22f, sinirZ);
            }

            if (transform.position.z >= sinirz)
            {
                transform.position = new Vector3(transform.position.x, 22f, sinirz);
            }


        }




    }
    public GameObject pervaneacma;
    public GameObject pervanetet;
    public GameObject pervanetet2;
    public GameObject pervanetetut;
    public GameObject pervanetetut2;

    public AudioSource carp;
    public AudioClip oyuncucarp;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "durma2")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;

            kontrol = false;
            kuvvet.velocity = Vector3.zero;

        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "durma")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;

            kontrol = false;
            kuvvet.velocity = Vector3.zero;
            
            //gameObject.GetComponent<Rigidbody>().isKinematic = false;
            
        }
        else
        {
            kontrol = true;
            kuvvet.velocity = new Vector3(-kuvvethiz, 0, 0);
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

        if (other.gameObject.tag == "buyuktop")
        {
            carp.PlayOneShot(oyuncucarp);
        }

        if (other.gameObject.tag == "durma2")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;

            kontrol = false;
            kuvvet.velocity = Vector3.zero;

           

        }

        if (other.gameObject.tag=="pervanetetik")
        {
            Destroy(pervaneacma);
            pervanetet.SetActive(true);
            pervanetet2.SetActive(true);
            pervanetetut.SetActive(true);
            pervanetetut2.SetActive(true);
        }
        


    }

    

    
}
