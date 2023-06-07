using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

    bool oyundurduruldu = false;

    
    
    void Start()
    {
        
    }
    

   
    
    public void oyundurdur_btn()
    {
        oyundurduruldu = !oyundurduruldu;

        if (oyundurduruldu == true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
   
    void Update()
    {
        
    }
}
