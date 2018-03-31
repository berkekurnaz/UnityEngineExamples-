using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZarSimulasyon : MonoBehaviour
{

    public int hiz1, hiz2;
    public GameObject zar1, zar2;
    public GameObject CanvasBaslangic, CanvasTekrarAt;

    void Start()
    {
        /*Başlangıçta Zar At Butonu Ve Ana Menü Butonu Aktif,Tekrar At Butonu İse Pasif Durumda*/
        CanvasBaslangic.SetActive(true);
        CanvasTekrarAt.SetActive(false);
    }

    /*Zar At Butonuna Tıklaayınca Gerçekleşecek Olaylar*/
    public void BtnZarAtTiklama()
    {
        zar1.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, Random.Range(hiz1, hiz2)));
        zar2.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, Random.Range(hiz1, hiz2)));
        CanvasBaslangic.SetActive(false);
        CanvasTekrarAt.SetActive(true);
    }

    /*Ana Menü Butonuna Tıklaayınca Gerçekleşecek Olaylar*/
    public void BtnAnaMenuTiklama()
    {
        SceneManager.LoadScene("LvlZarMenu");
    }

    /*Tekrar At Butonuna Tıklaayınca Gerçekleşecek Olaylar*/
    public void BtnTekrarAtTiklama()
    {
        SceneManager.LoadScene("LvlSimulasyon");
    }


    void Update()
    {
        /*Cihazın Geri Tuşuna Basınca Gerçekleşecek Olay...*/
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LvlZarMenu");
        }
    }
}
