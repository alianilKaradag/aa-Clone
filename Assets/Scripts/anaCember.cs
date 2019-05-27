using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anaCember : MonoBehaviour
{
    public GameObject kucukCember;

    GameObject OyunYoneticisi;

    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            KucukCemberOlustur();
        }
    }

    void KucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<oyunYoneticisi>().KucukCemberlerdeTextGosterme();
    }
}
