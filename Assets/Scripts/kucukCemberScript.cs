using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberScript : MonoBehaviour
{
    public float hiz;

    bool hareketKontrol = false;

    Rigidbody2D fizik;
    GameObject oyunYoneticisiScript;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisiScript=GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }

    
    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * Time.deltaTime * hiz);
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donenCemberTag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
        }

        if (col.tag == "kucukCemberTag")
        {
            oyunYoneticisiScript.GetComponent<oyunYoneticisi>().OyunBitti();
        }
    }
}
