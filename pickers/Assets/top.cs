using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{

    [SerializeField] Rigidbody[] toprbs = new Rigidbody[0];

    void Start()
    {
        Invoke("topdusme",1.3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="sepetsayi")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void topdusme()
    {
        for (int i = 0; i < toprbs.Length; i++)
        {
            toprbs[i].useGravity = true;
        }
    }



    void Update()
    {
        
    }
}
