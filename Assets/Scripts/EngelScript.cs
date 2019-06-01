using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelScript : MonoBehaviour
{
    
   
   
    public float hiz;

    bool sagaHareket = true;
    bool solaHareket = false;

    void Start()
    {
        
        
        
    }

    
    void Update()
    {

        EngelHareket();
        
    }

   void EngelHareket()
    {
        if (sagaHareket==true && solaHareket==false)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * hiz;
            
        }

        if(solaHareket==true && sagaHareket==false)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * hiz;
        }

      

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sagColliderTag")
        {
            sagaHareket = false;
            solaHareket = true;
            
        }

        if (col.gameObject.tag == "solColliderTag")
        {
            sagaHareket = true;
            solaHareket = false;
            
        }
    }
}
