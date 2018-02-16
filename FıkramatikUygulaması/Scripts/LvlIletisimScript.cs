using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlIletisimScript : MonoBehaviour
{

    // Use this for initialization
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

    public void BtnAyarlarClick()
    {
        Application.LoadLevel("LvlAyarlar");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
