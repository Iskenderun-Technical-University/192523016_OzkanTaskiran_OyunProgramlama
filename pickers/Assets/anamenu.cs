using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
   
    void Start()
    {
        //Time.timeScale = 0.0f;
    }


    //public GameObject baslamenü;
 

    public void basla_btn()
    {
        
     
            SceneManager.LoadScene("Scenes/SampleScene");

    }



    void Update()
    {
        
    }
}
