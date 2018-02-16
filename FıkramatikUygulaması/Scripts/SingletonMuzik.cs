using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingletonMuzik : MonoBehaviour
{

    public static SingletonMuzik instance;
    public int vie;

    public AudioSource source;

    public float sesDuzeyi;

    void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        source=GetComponent<AudioSource>();
    }

    void OnLevelWasLoaded(int level)
    {
        if (Application.loadedLevelName == "LvlKategoriAvci" || Application.loadedLevelName == "LvlKategoriKaradeniz" || Application.loadedLevelName == "LvlKategoriHoca" || Application.loadedLevelName == "LvlKategoriOgrenci" || Application.loadedLevelName == "LvlKategoriTemel")
        {
            instance = null;
            Destroy(gameObject);
        }
    }



    void Update()
    {
        sesDuzeyi = PlayerPrefs.GetFloat("DuzeySes");
        source.volume = sesDuzeyi;
    }

}
