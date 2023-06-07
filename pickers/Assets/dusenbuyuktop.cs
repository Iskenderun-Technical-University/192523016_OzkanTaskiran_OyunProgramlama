using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusenbuyuktop : MonoBehaviour
{

   
    

    public float hiz;
    public Rigidbody rbb;
    
    void Start()
    {
        StartCoroutine(buyuktopdusme());
       
    }

    
    void Update()
    {
      
    }


    public AudioSource kirma;
    public AudioClip ses11;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="zemin2")
        {
            kirma.PlayOneShot(ses11);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject,0.7f);
            spawn();

            
        }
    }

    public Transform kucuktop, buyuktop;

    public void spawn()
    {
        for (int i = 1; i < 20; i++)
        {
            Instantiate(kucuktop, buyuktop.position + Random.insideUnitSphere * 3, Quaternion.identity);
        }

    }

    [SerializeField] private float time;

    IEnumerator buyuktopdusme()
    {

        while (true)
        {
            yield return new WaitForSeconds(time);
            dusme();
        }
       



        

    }

    [SerializeField] Rigidbody[] rbs = new Rigidbody[0];

    
    public void dusme()
    {
        if (level2sepet.skorlevel2_1 >= 25)
        {
            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].isKinematic = false;
            }


            /*
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            rbb.velocity = new Vector3(0, -hiz, 0);
            */
        }

    }
}
