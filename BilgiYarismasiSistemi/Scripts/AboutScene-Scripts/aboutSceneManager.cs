using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Unity UI Kutuphanesini Ekledik...
using UnityEngine.SceneManagement; //Sahne Gecisleri Icin SceneManagement Kutuphanesini Ekledik... 

public class aboutSceneManager : MonoBehaviour
{

    /*BtnMainMenu Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMainMenuClick()
    {
        SceneManager.LoadScene("MainScene");
    }

    void FixedUpdate()
    {
        /*Geri Tusuna Basinca Gerceklesecek Olaylar*/
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

}
