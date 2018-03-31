using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{

    /*Başlama Butonu Tıklama Olayları...*/
    public void BtnBaslaTiklama()
    {
        SceneManager.LoadScene("LvlZarMenu");
    }

    /*Bilgi Butonu Tıklama Olayları...*/
    public void BtnBilgiTiklama()
    {
        SceneManager.LoadScene("LvlBilgi");
    }

    /*Çıkış Butonu Tıklama Olayları...*/
    public void BtnCikisTiklama()
    {
        Application.Quit();
    }

}
