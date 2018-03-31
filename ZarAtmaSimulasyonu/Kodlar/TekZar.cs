using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TekZar : MonoBehaviour 
{

    public RawImage Zar;
    public Texture[] ZarResimleri;

    public Text TxtZarNumara;
    public int sayi1;

    /*Uygulama Başında Gerçekleşecek Olaylar*/
    void Start()
    {
        Zar.texture = ZarResimleri[0];
    }

    /*Salla Butonuna Tıklayınca Gerçekleşecek Olaylar*/
    public void BtnSallaTiklama()
    {

        sayi1 = Random.Range(1, 7);

        if(sayi1==1)
        {
            Zar.texture = ZarResimleri[1];
            TxtZarNumara.text = sayi1.ToString();
        }
        if(sayi1 == 2)
        {
            Zar.texture = ZarResimleri[2];
            TxtZarNumara.text = sayi1.ToString();
        }
        if(sayi1 == 3)
        {
            Zar.texture = ZarResimleri[3];
            TxtZarNumara.text = sayi1.ToString();
        }
        if(sayi1 == 4)
        {
            Zar.texture = ZarResimleri[4];
            TxtZarNumara.text = sayi1.ToString();
        }
        if(sayi1 == 5)
        {
            Zar.texture = ZarResimleri[5];
            TxtZarNumara.text = sayi1.ToString();
        }
        if(sayi1 == 6)
        {
            Zar.texture = ZarResimleri[6];
            TxtZarNumara.text = sayi1.ToString();
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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LvlZarMenu");
        }
    }

}
