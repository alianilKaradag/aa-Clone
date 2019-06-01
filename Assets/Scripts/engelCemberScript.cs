using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelCemberScript : MonoBehaviour
{
    public GameObject engelCember;

    public float minTime = 2f;
    public float maxTime = 5f;

    private float zaman;
    private float dogusSüresi;

    

    void FixedUpdate()
    {
        
        zaman += Time.deltaTime;

        StartCoroutine(ZamanKontrol());

        //Check if its the right time to spawn the object

    }
    void NesneyiCagir()
    {
        StartCoroutine(NesneOlustur());
    }
    IEnumerator NesneOlustur()
    {
        zaman = minTime;
        Instantiate(engelCember, transform.position, engelCember.transform.rotation);

        yield return new WaitForSeconds(2);

        Destroy(engelCember.gameObject);
        
        
    }

    IEnumerator ZamanKontrol()
    {
        if (zaman >= dogusSüresi)
        {
            NesneyiCagir();
            dogusSüresi = Random.Range(minTime, maxTime);

            yield return new WaitForSeconds(2);
        }
    }
    

}
