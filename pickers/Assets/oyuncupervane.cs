using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncupervane : MonoBehaviour
{
    public float hiz;
    public GameObject pervane2;
    void Start()
    {
        
    }

   
    
    void Update()
    {
        transform.Rotate(0,-3*hiz,0);
        
        pervane2.transform.Rotate(0,3*hiz,0);
    }
}
