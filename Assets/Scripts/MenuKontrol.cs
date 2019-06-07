using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
   
    public void OyunaGit()
    {
        int kayitliLevel = PlayerPrefs.GetInt("levelKayit"); /// oyun yoneticisi criptinde olusturdugumuz kaydi burada cagırıyoruz

        if (kayitliLevel==0)                    // oyuna yeni baslıyorsak sürekli anamenüye dondurmemesi için kontrol ekliyoruz
        {
            SceneManager.LoadScene(kayitliLevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitliLevel);
        }
        
    }
    public void LevelleriSifirla()
    {
        PlayerPrefs.DeleteAll();
    }
   

    public void Cik()
    {
        Application.Quit();
    }
}
