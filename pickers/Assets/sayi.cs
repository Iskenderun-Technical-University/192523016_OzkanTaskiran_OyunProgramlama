using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class sayi : MonoBehaviour
{
    int skor=0;
    int skor2 = 0;
    
    TextMeshProUGUI skor_txt;
    TextMeshProUGUI skor2_txt;
    

    //public saðkapi Saðkapi;
    // public solkapi Solkapi;

    public GameObject sonrakizemin;

    void Start()
    {
        skor_txt = GameObject.Find("Canvas/skor_txt").GetComponent<TextMeshProUGUI>();
        skor2_txt = GameObject.Find("Canvas/skor2_txt").GetComponent<TextMeshProUGUI>();
        efekt.Stop();
       
    }

    
     public  void acilmasaniye()
    {
        sonrakizemin.SetActive(true);
    }

    public GameObject durmatetik;
    public GameObject yenidenoyna_pnlob;


    public ParticleSystem efekt;

    public AudioSource ses;
    public AudioClip blop;

   


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="top")
        {
            // Invoke("açýlmasaniye", 3.5f);

            if (skor>=15)
            {
                Invoke("acilmasaniye",3f);
                Destroy(durmatetik,3.2f);
                //Destroy(itmetetik, 3.5f);

            }
            else
            {
                Invoke("yenidenoyna_pnl",3.8f);
            }

            skor += 1;
            skor_txt.text = skor.ToString();
            efekt.Play();
            ses.PlayOneShot(blop);

        }

        if (collision.gameObject.tag == "silindir")
        {
            // Invoke("açýlmasaniye", 3.5f);

            ses.PlayOneShot(blop);
            efekt.Play();
            skor2 += 1;
            skor2_txt.text = skor2.ToString();

            if (skor2<15)
            {
                Invoke("yenidenoyna_pnl2",4.3f);
            }

            if (skor2 >= 15)
            {
                Invoke("sonrakilevel_pnl", 3f);
            }

        }

        
    }

    public void yenidenoyna_pnl()
    {
        if (skor<15)
        {
            yenidenoyna_pnlob.SetActive(true);
        }
        
    }

    public void yenidenoyna_pnl2()
    {
        if (skor2 < 15)
        {
            yenidenoyna_pnlob.SetActive(true);
        }

    }

    public void yenidenoyna_btn()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public GameObject sonrakilevel;


    public void sonrakilevel_pnl()
    {

        if (skor2 >= 15)
        {
            sonrakilevel.SetActive(true);
        }
        
    }

    public void sonrakilevel_btn()
    {
        SceneManager.LoadScene("Scenes/2.level");
    }

    void Update()
    {
        

    }
}
