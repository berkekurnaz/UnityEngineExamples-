using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Unity UI Kutuphanesini Ekledik...
using UnityEngine.SceneManagement; //Sahne Gecisleri Icin SceneManagement Kutuphanesini Ekledik... 

public class mainSceneManager : MonoBehaviour
{

    public GameObject CnvMain;
    public GameObject CnvGelistirmeAsamasi;
    public GameObject CnvPauseMenu;

    void Start()
    {
        CnvMain.SetActive(true);
        CnvGelistirmeAsamasi.SetActive(false);
        CnvPauseMenu.SetActive(false);
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            CnvGelistirmeAsamasi.SetActive(false);
            CnvPauseMenu.SetActive(true);
        }
    }

    /*BtnEasy Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnEasyClick()
    {
        SceneManager.LoadScene("EasyQuestionScene");
    }

    /*BtnMedium Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMediumClick()
    {
        CnvMain.SetActive(false);
        CnvGelistirmeAsamasi.SetActive(true);
    }

    /*BtnHard Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnHardClick()
    {
        CnvMain.SetActive(false);
        CnvGelistirmeAsamasi.SetActive(true);
    }

    /*BtnAbout Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnAboutClick()
    {
        SceneManager.LoadScene("AboutScene");
    }

    /*BtnFacebook Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnFacebookClick()
    {
        Application.OpenURL("https://www.facebook.com/bkoyun2014/");
    }

    /*BtnTwitter Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnTwitterClick()
    {
        Application.OpenURL("https://twitter.com/BKOyun2014");
    }

    /*BtnMainMenu Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMainMenuClick()
    {
        CnvMain.SetActive(true);
        CnvGelistirmeAsamasi.SetActive(false);
    }


    /*Mola Menusundeki BtnYes Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMenuYesClick()
    {
        Application.Quit();
    }

    /*Mola Menusundeki BtnNo Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMenuNoClick()
    {
        CnvGelistirmeAsamasi.SetActive(false);
        CnvPauseMenu.SetActive(false);
    }

}
