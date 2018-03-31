using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZarOyun : MonoBehaviour
{

    public GameObject BtnBirinciOyuncu;
    public GameObject BtnIkinciOyuncu;

    public GameObject BtnTekrarOyna;
    public GameObject BtnAnaMenu;

    public GameObject Oyuncu1Kutu;
    public GameObject Oyuncu2Kutu;

    public RawImage Zar1;
    public RawImage Zar2;
    public RawImage Zar3;
    public RawImage Zar4;

    public Texture[] ZarResimleri1;
    public Texture[] ZarResimleri2;
    public Texture[] ZarResimleri3;
    public Texture[] ZarResimleri4;

    public Text TxtZarNumara1;
    public Text TxtZarNumara2;
    public Text TxtZarNumara3;
    public Text TxtZarNumara4;

    public int sayi1;
    public int sayi2;
    public int sayi3;
    public int sayi4;

    public int toplam1;
    public int toplam2;

    public Text TxtBirinciSkor;
    public Text TxtIkinciSkor;

    public Text TxtKazanan;
    public Text TxtOrtaBilgi;

    /*Uygulama Başında Gerçekleşecek Olaylar*/
    void Start()
    {
        Zar1.texture = ZarResimleri1[0];
        Zar2.texture = ZarResimleri2[0];

        toplam1 = 0;
        toplam2 = 0;

        TxtBirinciSkor.text = toplam1.ToString();
        TxtIkinciSkor.text = toplam2.ToString();

        BtnBirinciOyuncu.SetActive(true);
        BtnIkinciOyuncu.SetActive(false);

        BtnTekrarOyna.SetActive(false);
        BtnAnaMenu.SetActive(false);

        Oyuncu1Kutu.SetActive(true);
        Oyuncu2Kutu.SetActive(true);

        TxtKazanan.text = "100 OLAN KAZANIR";
        TxtOrtaBilgi.text = "";
    }

    public void BtnBirinciOyuncuTiklama()
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

        toplam1 = toplam1 + sayi1 + sayi2;
        TxtBirinciSkor.text = toplam1.ToString();

        BtnBirinciOyuncu.SetActive(false);
        BtnIkinciOyuncu.SetActive(true);
    }

    public void BtnIkinciOyuncuTiklama()
    {

        sayi3 = Random.Range(1, 7);
        sayi4 = Random.Range(1, 7);

        if (sayi3 == 1)
        {
            Zar3.texture = ZarResimleri3[1];
            TxtZarNumara3.text = sayi3.ToString();
        }
        if (sayi3 == 2)
        {
            Zar3.texture = ZarResimleri3[2];
            TxtZarNumara3.text = sayi3.ToString();
        }
        if (sayi3 == 3)
        {
            Zar3.texture = ZarResimleri3[3];
            TxtZarNumara3.text = sayi3.ToString();
        }
        if (sayi3 == 4)
        {
            Zar3.texture = ZarResimleri3[4];
            TxtZarNumara3.text = sayi3.ToString();
        }
        if (sayi3 == 5)
        {
            Zar3.texture = ZarResimleri3[5];
            TxtZarNumara3.text = sayi3.ToString();
        }
        if (sayi3 == 6)
        {
            Zar3.texture = ZarResimleri3[6];
            TxtZarNumara3.text = sayi3.ToString();
        }


        if (sayi4 == 1)
        {
            Zar4.texture = ZarResimleri4[1];
            TxtZarNumara4.text = sayi4.ToString();
        }
        if (sayi4 == 2)
        {
            Zar4.texture = ZarResimleri4[2];
            TxtZarNumara4.text = sayi4.ToString();
        }
        if (sayi4 == 3)
        {
            Zar4.texture = ZarResimleri4[3];
            TxtZarNumara4.text = sayi4.ToString();
        }
        if (sayi4 == 4)
        {
            Zar4.texture = ZarResimleri4[4];
            TxtZarNumara4.text = sayi4.ToString();
        }
        if (sayi4 == 5)
        {
            Zar4.texture = ZarResimleri4[5];
            TxtZarNumara4.text = sayi4.ToString();
        }
        if (sayi4 == 6)
        {
            Zar4.texture = ZarResimleri4[6];
            TxtZarNumara4.text = sayi4.ToString();
        }

        toplam2 = toplam2 + sayi3 + sayi4;
        TxtIkinciSkor.text = toplam2.ToString();

        BtnBirinciOyuncu.SetActive(true);
        BtnIkinciOyuncu.SetActive(false);

        if (toplam1 >= 100 && toplam1 > toplam2)
        {
            TxtKazanan.text = "1. Oyuncu Kazandı....";
            TxtOrtaBilgi.text = "Kazanan 1.Oyuncu";
            Invoke("OyunBitis", 0.1f);
        }

        if (toplam2 >= 100 && toplam2 > toplam1)
        {
            TxtKazanan.text = "2. Oyuncu Kazandı....";
            TxtOrtaBilgi.text = "Kazanan 2.Oyuncu";
            Invoke("OyunBitis", 0.1f);
        }

    }

    /*Tekrar Oyna Butonuna Tıklayınca Gerçekleşecek Olay...*/
    public void BtnTekrarOynaTiklama()
    {
        SceneManager.LoadScene("LvlOyun");
    }

    /*Ana Menü Butonuna Tıklayınca Gerçekleşecek Olay...*/
    public void BtnAnaMenuTiklama()
    {
        SceneManager.LoadScene("LvlZarMenu");
    }

    void OyunBitis()
    {
        BtnTekrarOyna.SetActive(true);
        BtnAnaMenu.SetActive(true);

        Oyuncu1Kutu.SetActive(false);
        Oyuncu2Kutu.SetActive(false);
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
