using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CiftZar : MonoBehaviour
{

    public RawImage Zar1;
    public RawImage Zar2;

    public Texture[] ZarResimleri1;
    public Texture[] ZarResimleri2;

    public Text TxtZarNumara1;
    public Text TxtZarNumara2;

    public int sayi1;
    public int sayi2;

    /*Uygulama Başında Gerçekleşecek Olaylar*/
    void Start()
    {
        Zar1.texture = ZarResimleri1[0];
        Zar2.texture = ZarResimleri2[0];
    }

    /*Salla Butonuna Tıklayınca Gerçekleşecek Olaylar*/
    public void BtnSallaTiklama()
    {

        sayi1 = Random.Range(1, 7);
        sayi2 = Random.Range(1, 7);

        if (sayi1 == 1)
        {
            Zar1.texture = ZarResimleri1[1];
            TxtZarNumara1.text = sayi1.ToString();
        }
        if (sayi1 == 2)
        {
            Zar1.texture = ZarResimleri1[2];
            TxtZarNumara1.text = sayi1.ToString();
        }
        if (sayi1 == 3)
        {
            Zar1.texture = ZarResimleri1[3];
            TxtZarNumara1.text = sayi1.ToString();
        }
        if (sayi1 == 4)
        {
            Zar1.texture = ZarResimleri1[4];
            TxtZarNumara1.text = sayi1.ToString();
        }
        if (sayi1 == 5)
        {
            Zar1.texture = ZarResimleri1[5];
            TxtZarNumara1.text = sayi1.ToString();
        }
        if (sayi1 == 6)
        {
            Zar1.texture = ZarResimleri1[6];
            TxtZarNumara1.text = sayi1.ToString();
        }


        if (sayi2 == 1)
        {
            Zar2.texture = ZarResimleri2[1];
            TxtZarNumara2.text = sayi2.ToString();
        }
        if (sayi2 == 2)
        {
            Zar2.texture = ZarResimleri2[2];
            TxtZarNumara2.text = sayi2.ToString();
        }
        if (sayi2 == 3)
        {
            Zar2.texture = ZarResimleri2[3];
            TxtZarNumara2.text = sayi2.ToString();
        }
        if (sayi2 == 4)
        {
            Zar2.texture = ZarResimleri2[4];
            TxtZarNumara2.text = sayi2.ToString();
        }
        if (sayi2 == 5)
        {
            Zar2.texture = ZarResimleri2[5];
            TxtZarNumara2.text = sayi2.ToString();
        }
        if (sayi2 == 6)
        {
            Zar2.texture = ZarResimleri2[6];
            TxtZarNumara2.text = sayi2.ToString();
        }

    }

    /*Geri Butonuna Tıklayınca Gerçekleşecek Olaylar*/
    public void BtnGeriTiklama()
    {
        SceneManager.LoadScene("LvlZarMenu");
    }

    void Update()
    {
        /*Cihazın Geri Tuşuna Basınca Gerçekleşecek Olay...*/
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LvlZarMenu");
        }
    }

}
