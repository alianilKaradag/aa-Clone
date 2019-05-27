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

    private static NesneyiYokEtme instance = null;          // müziğin sahneler arası geçişte devam etmesi için bu scripti yazdık..

    public static NesneyiYokEtme Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if(instance!=null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
