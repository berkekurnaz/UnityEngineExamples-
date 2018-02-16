using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlAnaSayfaScript : MonoBehaviour
{

    public AudioClip tıklamaSesi;
    public AudioSource source;

    void Start()
    {
        source=GetComponent<AudioSource>();
    }


    public void BtnBlogClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlBlog");
    }

    public void BtnAyarlarClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlAyarlar");
    }

    public void BtnIletisimClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlIletisim");
    }


    //Kategori Sayfaları İçin Tıklama Olayları...
    public void BtnKategoriAvciClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlKategoriAvci");
    }

    public void BtnKategoriKaradenizClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlKategoriKaradeniz");
    }

    public void BtnKategoriHocaClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlKategoriHoca");
    }

    public void BtnKategoriOgrenciClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlKategoriOgrenci");
    }

    public void BtnKategoriTemelClick()
    {
        source.PlayOneShot(tıklamaSesi);
        Application.LoadLevel("LvlKategoriTemel");
    }

    void Update()
    {

    }
}
