using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public GameObject anaPanel;
    public GameObject nasilOynanirPanel;
    public GameObject hakkindaPanel;
    public GameObject cikisPanel;

    void Start()
    {
        anaPanel.SetActive(true);
        nasilOynanirPanel.SetActive(false);
        hakkindaPanel.SetActive(false);
        cikisPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            anaPanel.SetActive(true);
            nasilOynanirPanel.SetActive(false);
            hakkindaPanel.SetActive(false);
            cikisPanel.SetActive(false);
        }
    }

    public void Btn_Basla_Click()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }

    public void Btn_Nasil_Oynanir_Click()
    {
        anaPanel.SetActive(false);
        nasilOynanirPanel.SetActive(true);
        hakkindaPanel.SetActive(false);
        cikisPanel.SetActive(false);
    }

    public void Btn_Hakkinda_Click()
    {
        anaPanel.SetActive(false);
        nasilOynanirPanel.SetActive(false);
        hakkindaPanel.SetActive(true);
        cikisPanel.SetActive(false);
    }

    public void Btn_Cikis_Click()
    {
        anaPanel.SetActive(false);
        nasilOynanirPanel.SetActive(false);
        hakkindaPanel.SetActive(false);
        cikisPanel.SetActive(true);
    }

    public void Btn_Ana_Menu_Don_Click()
    {
        anaPanel.SetActive(true);
        nasilOynanirPanel.SetActive(false);
        hakkindaPanel.SetActive(false);
        cikisPanel.SetActive(false);
    }

    public void Btn_Oyundan_Cik_Evet_Click()
    {
        Application.Quit();
    }

}
