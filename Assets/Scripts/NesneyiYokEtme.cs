using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneyiYokEtme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static NesneyiYokEtme ornek = null;          /// müziğin sahneler arası geçişte devam etmesi için bu scripti yazdık..

    public static NesneyiYokEtme Ornek
    {
        get { return ornek; }
    }

    private void Awake()
    {
        if(ornek!=null && ornek != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            ornek = this;
        }
        DontDestroyOnLoad(this.gameObject);                 ///
    }
}
