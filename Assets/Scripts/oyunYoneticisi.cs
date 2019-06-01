using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunYoneticisi : MonoBehaviour
{
    GameObject donenCember;
    GameObject anaCember;
    GameObject engel;

    bool YeniLeveleGecilsinmi = true;

    public Animator animator;
    public Text DonenCemberLevel;
    public Text Bir;
    public Text Iki;
    public Text Uc;
    public int KacTaneKucukCemberOlsun;
    

    void Start()
    {
        PlayerPrefs.SetInt("levelKayit", int.Parse(SceneManager.GetActiveScene().name));// hangi levelde kaldığımızı kaydediyoruz

        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("anaCemberTag");
        engel = GameObject.FindGameObjectWithTag("engelTag");
        DonenCemberLevel.text = SceneManager.GetActiveScene().name;

        if (KacTaneKucukCemberOlsun<2)
        {
            Bir.text = KacTaneKucukCemberOlsun + "";        //  "" ile toplamamızın sebebi stringe cevirmek
        }
        else if (KacTaneKucukCemberOlsun<3)
        {
            Bir.text = KacTaneKucukCemberOlsun + "";
            Iki.text = (KacTaneKucukCemberOlsun-1) + "";
        }
        else
        {
            Bir.text = KacTaneKucukCemberOlsun + "";
            Iki.text = (KacTaneKucukCemberOlsun - 1) + "";
            Uc.text = (KacTaneKucukCemberOlsun - 2) + "";
        }

    }

    public void KucukCemberlerdeTextGosterme()
    {
        KacTaneKucukCemberOlsun--;

        if (KacTaneKucukCemberOlsun < 2)
        {
            Bir.text = KacTaneKucukCemberOlsun + "";        //  "" ile toplamamızın sebebi stringe cevirmek
            Iki.text =  "";
            Uc.text = "";
        }
        else if (KacTaneKucukCemberOlsun < 3)
        {
            Bir.text = KacTaneKucukCemberOlsun + "";
            Iki.text = (KacTaneKucukCemberOlsun - 1) + "";
            Uc.text =  "";
        }
        else
        {
            Bir.text = KacTaneKucukCemberOlsun + "";
            Iki.text = (KacTaneKucukCemberOlsun - 1) + "";
            Uc.text = (KacTaneKucukCemberOlsun - 2) + "";
        }

        if (KacTaneKucukCemberOlsun == 0)
        {
            StartCoroutine(YeniLevel());
        }
    }

    IEnumerator YeniLevel()
    {
        donenCember.GetComponent<dondurme>().enabled = false;
        anaCember.GetComponent<anaCember>().enabled = false;
        engel.GetComponent<EngelScript>().enabled = false;


        yield return new WaitForSeconds(0.5f);

        if (YeniLeveleGecilsinmi)
        {
            animator.SetTrigger("yeniLevelAnim");

            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
        
    }

    public void OyunBitti()
    {
        StartCoroutine(oyunBitisFonksiyonlari());           //oyun bittiğinde aşağıdaki metodu çağırıyoruz.
    }
    
    IEnumerator oyunBitisFonksiyonlari()
    {
        donenCember.GetComponent<dondurme>().enabled = false;
        anaCember.GetComponent<anaCember>().enabled = false;
        engel.GetComponent<EngelScript>().enabled = false;
        animator.SetTrigger("oyunBittiAnim");
        YeniLeveleGecilsinmi = false;

        yield return new WaitForSeconds(2.3f);                 //kodu 1 saniye bekletiyoruz

        SceneManager.LoadScene("anaMenu");
    }
}
