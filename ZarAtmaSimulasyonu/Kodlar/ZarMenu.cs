using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZarMenu : MonoBehaviour 
{

    /*Ana Menü Butonu Tıklama Olayları*/
    public void BtnAnaMenuTiklama()
    {
        SceneManager.LoadScene("LvlMenu");
    }

    /*Tek Zar Butonu Tıklama Olayları*/
    public void BtnTekZarOynaTiklama()
    {
        SceneManager.LoadScene("LvlTekZar");
    }

    /*Çift Zar Butonu Tıklama Olayları*/
    public void BtnCiftZarOynaTiklama()
    {
        SceneManager.LoadScene("LvlCiftZar");
    }

    /*3D Zar Simulasyonu Butonu Tıklama Olayları*/
    public void BtnZarSimulasyonuTiklama()
    {
        SceneManager.LoadScene("LvlSimulasyon");
    }

    /*İki Kişi Oyna Butonu Tıklama Olayları*/
    public void BtnIkiKisiOynaTiklama()
    {
        SceneManager.LoadScene("LvlOyun");
    }
	
	void Update () 
    {
        /*Cihazın Geri Tuşuna Basınca Gerçekleşecek Olay...*/
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LvlMenu");
        }
	}
}
