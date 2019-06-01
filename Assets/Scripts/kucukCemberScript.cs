using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberScript : MonoBehaviour
{
    public float hiz;

    bool hareketEtsinMi = true;

    Rigidbody2D fizik;
    GameObject oyunYoneticisiScript;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisiScript=GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }

    
    void FixedUpdate()
    {
        if (hareketEtsinMi)
        {
            fizik.MovePosition(fizik.position + Vector2.up * Time.deltaTime * hiz);
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donenCemberTag")
        {
            transform.SetParent(col.transform);
            hareketEtsinMi = false;
        }

        if (col.tag == "kucukCemberTag")
        {
            oyunYoneticisiScript.GetComponent<oyunYoneticisi>().OyunBitti();
        }

        if (col.tag == "engelTag")
        {
            transform.localScale = new Vector3(2,2,2);
            transform.SetParent(col.transform);
            hareketEtsinMi = false;
            oyunYoneticisiScript.GetComponent<oyunYoneticisi>().OyunBitti();
        }
    }
}
