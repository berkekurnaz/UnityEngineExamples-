using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlAyarlarScript : MonoBehaviour
{
    public float sesDuzeyi;
    public Slider slider;

    void Start()
    {

    }

    public void BtnAnaSayfaClick()
    {
        Application.LoadLevel("LvlAnaSayfa");
    }

    public void BtnBlogClick()
    {
        Application.LoadLevel("LvlBlog");
    }

    public void BtnIletisimClick()
    {
        Application.LoadLevel("LvlIletisim");
    }




    void Update()
    {
        PlayerPrefs.SetFloat("DuzeySes", slider.value);

        sesDuzeyi = PlayerPrefs.GetFloat("DuzeySes");
        slider.value = sesDuzeyi;
    }
}
