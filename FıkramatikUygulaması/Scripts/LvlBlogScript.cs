using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlBlogScript : MonoBehaviour
{

    public GameObject PnlHaber1;

    public Text TxtBaslik;
    public Button BtnHaber1, BtnHaber2, BtnHaber3;

    public Animator anim;

    void Start()
    {
        /*Oyun Başında Baslik Yazımız Aktif...*/
        TxtBaslik.gameObject.SetActive(true);

        /*Oyun Başında Haber Butonlarımız Açık...*/
        BtnHaber1.gameObject.SetActive(true);
        BtnHaber2.gameObject.SetActive(true);
        BtnHaber3.gameObject.SetActive(true);

    }

    public void BtnAnaSayfaClick()
    {
        Application.LoadLevel("LvlAnaSayfa");
    }

    public void BtnAyarlarClick()
    {
        Application.LoadLevel("LvlAyarlar");
    }

    public void BtnIletisimClick()
    {
        Application.LoadLevel("LvlIletisim");
    }

    public void BtnHaber1Click()
    {
        /*Panelimiz Aktf Hale Getirdik*/
        PnlHaber1.SetActive(true);

        /*BtnHaber1 Butonuna Tıklayınca Baslik Yazımız Kaybolacak...*/
        TxtBaslik.gameObject.SetActive(false);

        /*BtnHaber1 Butonuna Tıklayınca Butonlarımız Yok Olacak...*/
        BtnHaber1.gameObject.SetActive(false);
        BtnHaber2.gameObject.SetActive(false);
        BtnHaber3.gameObject.SetActive(false);

        anim.SetBool("flag", true);
        
    }

    public void BtnDetaylariKapat()
    {
        /*Panelimiz Kapalı Hale Getirdik*/
        PnlHaber1.SetActive(false);

        /*BtnDetaylariKapat Butonuna Tıklayınca Baslik Yazımız Aktif Olacak...*/
        TxtBaslik.gameObject.SetActive(true);

        /*BtnDetaylariKapat Butonuna Tıklayınca Butonlarımız Aktif Olacak....*/
        BtnHaber1.gameObject.SetActive(true);
        BtnHaber2.gameObject.SetActive(true);
        BtnHaber3.gameObject.SetActive(true);

    }

    void Update()
    {

    }
}
