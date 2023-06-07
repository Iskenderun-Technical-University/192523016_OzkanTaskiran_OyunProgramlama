using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class level2sepet : MonoBehaviour
{
   public static int skorlevel2_1 = 0;
    int skor_2 = 0;
    TextMeshProUGUI skor1level2_txt;
    TextMeshProUGUI skor1level22_txt;




    void Start()
    {
        skor1level2_txt = GameObject.Find("Canvas/skor1level2_txt").GetComponent<TextMeshProUGUI>();
        skor1level22_txt = GameObject.Find("Canvas/skor2_txt").GetComponent<TextMeshProUGUI>();
    }

    public AudioSource ses;
    public AudioClip blop;

    public GameObject sonrakialan;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "level21")
        {
            skorlevel2_1 += 1;
            skor1level2_txt.text = skorlevel2_1.ToString();
            if (skorlevel2_1>=25)
            {
                Invoke(" acilmasaniye", 2.5f);
                
            }

            else
            {
                Invoke("yenidenoyna",2f);
            }

            ses.PlayOneShot(blop);
        }

        if (collision.gameObject.tag == "zemin")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }

        if (collision.gameObject.tag == "skor2")
        {
            skor_2 += 1;
            skor1level22_txt.text = skor_2.ToString();
            ses.PlayOneShot(blop);
        }


        }

    public void acilmasaniye()
    {
        sonrakialan.SetActive(true);
    }


    public GameObject yenidenoyna_pnl;

    public void yenidenoyna()
    {
        if (skorlevel2_1<25)
        {
            yenidenoyna_pnl.SetActive(true);
        }

    }

    public void yenidenoyna_btn()
    {
        SceneManager.LoadScene("Scenes/2.level");
    }



    void Update()
    {
        
    }
}
