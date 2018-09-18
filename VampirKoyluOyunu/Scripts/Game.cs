using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    public int oyuncu_Sayisi;

    int oyunKacKisilik;

    string oyuncu1;
    string oyuncu2;
    string oyuncu3;
    string oyuncu4;
    string oyuncu5;
    string oyuncu6;

    public string vampir;

    public Text LblOyunKacKisilik;
    public Text LblOyuncuIsmi;
    public Text LblRoluGoster;

    public Text LblSure;

    public Text BtnRolGosterGizle;
    public Button ButtonGosterGizle;
    public GameObject BtnTartismaBaslasin;

    public Dropdown TxtOyuncuSayisi;

    public InputField TxtOyuncu1;
    public InputField TxtOyuncu2;
    public InputField TxtOyuncu3;
    public InputField TxtOyuncu4;
    public InputField TxtOyuncu5;
    public InputField TxtOyuncu6;

    public GameObject Panel_OyuncuSayisi;
    public GameObject Panel_OyuncuIsimlendirme;
    public GameObject Panel_OyuncuRolleri;
    public GameObject Panel_RolleriGoster;
    public GameObject Panel_TartismaEkrani;
    public GameObject Panel_OyunuBitir;
    public GameObject Panel_OyuncuEle;
    public GameObject Panel_OyuncuEleDetay;
    public GameObject Panel_RastgeleOyuncuEle;

    public Text TxtElemeOyuncu1;
    public Text TxtElemeOyuncu2;
    public Text TxtElemeOyuncu3;
    public Text TxtElemeOyuncu4;
    public Text TxtElemeOyuncu5;
    public Text TxtElemeOyuncu6;
    public Text LblElenmeOyuncusu;
    public Text LblElenenRol;
    public Text LblRastgeleElenen;
    public GameObject BtnElemeOyuncu1;
    public GameObject BtnElemeOyuncu2;
    public GameObject BtnElemeOyuncu3;
    public GameObject BtnElemeOyuncu4;
    public GameObject BtnElemeOyuncu5;
    public GameObject BtnElemeOyuncu6;
    public GameObject BtnElemeDetayGeriDon;
    public Button BtnRastgeleEle;

    string elenmeDurumuOyuncu;

    int tiklamaSayi = 0;

    bool oyunBasladimi = false;

    [Header("Kontrol Grubu")]
    public bool sayfa1;
    public bool sayfa2;
    public bool sayfa3;
    public bool sayfa4;
    public bool sayfa5;

    [Header("İsimlendirme Gizleme Grubu")]
    public GameObject BtnGizlendirmeOyuncu4;
    public GameObject BtnGizlendirmeOyuncu5;
    public GameObject BtnGizlendirmeOyuncu6;
    public GameObject LblGizlendirmeOyuncu4;
    public GameObject LblGizlendirmeOyuncu5;
    public GameObject LblGizlendirmeOyuncu6;


    void Start()
    {
        Panel_OyuncuSayisi.SetActive(true);
        Panel_OyuncuIsimlendirme.SetActive(false);
        Panel_OyuncuRolleri.SetActive(false);
        Panel_RolleriGoster.SetActive(false);
        Panel_TartismaEkrani.SetActive(false);
        Panel_OyunuBitir.SetActive(false);
        Panel_OyuncuEle.SetActive(false);
        Panel_OyuncuEleDetay.SetActive(false);
        Panel_RastgeleOyuncuEle.SetActive(false);

        TxtOyuncu1.enabled = false;
        TxtOyuncu2.enabled = false;
        TxtOyuncu3.enabled = false;
        TxtOyuncu4.enabled = false;
        TxtOyuncu5.enabled = false;
        TxtOyuncu6.enabled = false;
        TxtOyuncu6.IsActive();
    }

    void Update()
    {
        if (ButtonGosterGizle.enabled == true)
        {
            BtnTartismaBaslasin.SetActive(false);
        }
        else
        {
            BtnTartismaBaslasin.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && sayfa1 == true)
        {
            Panel_OyuncuSayisi.SetActive(true);
            Panel_OyuncuIsimlendirme.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && sayfa2 == true)
        {
            Panel_OyuncuIsimlendirme.SetActive(true);
            Panel_OyuncuRolleri.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && sayfa3 == true)
        {
            Panel_TartismaEkrani.SetActive(true);
            Panel_OyunuBitir.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && sayfa4 == true)
        {
            Panel_TartismaEkrani.SetActive(true);
            Panel_OyuncuEle.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && sayfa5 == true)
        {
            Panel_TartismaEkrani.SetActive(true);
            Panel_RastgeleOyuncuEle.SetActive(false);
        }

    }

    public void Btn_Oyuncu_Sayisi_Devam_Et_Click()
    {
        sayfa1 = true;
        sayfa2 = false;
        sayfa3 = false;
        sayfa4 = false;
        sayfa5 = false;
        oyuncu_Sayisi = TxtOyuncuSayisi.value + 3;
        Panel_OyuncuSayisi.SetActive(false);
        Panel_OyuncuIsimlendirme.SetActive(true);
        if (TxtOyuncuSayisi.value + 3 == 3)
        {
            TxtOyuncu1.enabled = true;
            TxtOyuncu2.enabled = true;
            TxtOyuncu3.enabled = true;
            TxtOyuncu1.text = "Oyuncu 1";
            TxtOyuncu2.text = "Oyuncu 2";
            TxtOyuncu3.text = "Oyuncu 3";
            oyunKacKisilik = 3;
            BtnGizlendirmeOyuncu4.SetActive(false);
            BtnGizlendirmeOyuncu5.SetActive(false);
            BtnGizlendirmeOyuncu6.SetActive(false);
            LblGizlendirmeOyuncu4.SetActive(false);
            LblGizlendirmeOyuncu5.SetActive(false);
            LblGizlendirmeOyuncu6.SetActive(false);
        }
        else if(TxtOyuncuSayisi.value + 3 == 4)
        {
            TxtOyuncu1.enabled = true;
            TxtOyuncu2.enabled = true;
            TxtOyuncu3.enabled = true;
            TxtOyuncu4.enabled = true;
            TxtOyuncu1.text = "Oyuncu 1";
            TxtOyuncu2.text = "Oyuncu 2";
            TxtOyuncu3.text = "Oyuncu 3";
            TxtOyuncu4.text = "Oyuncu 4";
            BtnGizlendirmeOyuncu4.SetActive(true);
            BtnGizlendirmeOyuncu5.SetActive(false);
            BtnGizlendirmeOyuncu6.SetActive(false);
            LblGizlendirmeOyuncu4.SetActive(true);
            LblGizlendirmeOyuncu5.SetActive(false);
            LblGizlendirmeOyuncu6.SetActive(false);
            oyunKacKisilik = 4;
        }
        else if (TxtOyuncuSayisi.value + 3 == 5)
        {
            TxtOyuncu1.enabled = true;
            TxtOyuncu2.enabled = true;
            TxtOyuncu3.enabled = true;
            TxtOyuncu4.enabled = true;
            TxtOyuncu5.enabled = true;
            TxtOyuncu1.text = "Oyuncu 1";
            TxtOyuncu2.text = "Oyuncu 2";
            TxtOyuncu3.text = "Oyuncu 3";
            TxtOyuncu4.text = "Oyuncu 4";
            TxtOyuncu5.text = "Oyuncu 5";
            BtnGizlendirmeOyuncu4.SetActive(true);
            BtnGizlendirmeOyuncu5.SetActive(true);
            BtnGizlendirmeOyuncu6.SetActive(false);
            LblGizlendirmeOyuncu4.SetActive(true);
            LblGizlendirmeOyuncu5.SetActive(true);
            LblGizlendirmeOyuncu6.SetActive(false);
            oyunKacKisilik = 5;
        }
        else if (TxtOyuncuSayisi.value + 3 == 6)
        {
            TxtOyuncu1.enabled = true;
            TxtOyuncu2.enabled = true;
            TxtOyuncu3.enabled = true;
            TxtOyuncu4.enabled = true;
            TxtOyuncu5.enabled = true;
            TxtOyuncu6.enabled = true;
            TxtOyuncu1.text = "Oyuncu 1";
            TxtOyuncu2.text = "Oyuncu 2";
            TxtOyuncu3.text = "Oyuncu 3";
            TxtOyuncu4.text = "Oyuncu 4";
            TxtOyuncu5.text = "Oyuncu 5";
            TxtOyuncu6.text = "Oyuncu 6";
            BtnGizlendirmeOyuncu4.SetActive(true);
            BtnGizlendirmeOyuncu5.SetActive(true);
            BtnGizlendirmeOyuncu6.SetActive(true);
            LblGizlendirmeOyuncu4.SetActive(true);
            LblGizlendirmeOyuncu5.SetActive(true);
            LblGizlendirmeOyuncu6.SetActive(true);
            oyunKacKisilik = 6;
        }
    }

    public void Btn_Oyuncu_Isimlendirme_Devam_Et_Click()
    {
        sayfa1 = false;
        sayfa2 = true;
        sayfa3 = false;
        sayfa4 = false;
        sayfa5 = false;
        oyuncu1 = TxtOyuncu1.text;
        oyuncu2 = TxtOyuncu2.text;
        oyuncu3 = TxtOyuncu3.text;
        oyuncu4 = TxtOyuncu4.text;
        oyuncu5 = TxtOyuncu5.text;
        oyuncu6 = TxtOyuncu6.text;
        Panel_OyuncuIsimlendirme.SetActive(false);
        Panel_OyuncuRolleri.SetActive(true);
        LblOyunKacKisilik.text = "Oyun Kaç Kişilik : " + oyunKacKisilik.ToString();
    }

    public void Btn_Oyuna_Basla()
    {
        sayfa1 = false;
        sayfa2 = false;
        sayfa3 = false;
        sayfa4 = false;
        sayfa5 = false;
        int i = Random.Range(1, oyunKacKisilik + 1);
        if (i == 1)
        {
            vampir = oyuncu1;
        }
        else if(i == 2)
        {
            vampir = oyuncu2;
        }
        else if (i == 3)
        {
            vampir = oyuncu3;
        }
        else if (i == 4)
        {
            vampir = oyuncu4;
        }
        else if (i == 5)
        {
            vampir = oyuncu5;
        }
        else if (i == 6)
        {
            vampir = oyuncu6;
        }
        Panel_OyuncuRolleri.SetActive(false);
        Panel_RolleriGoster.SetActive(true);
        LblOyuncuIsmi.text = oyuncu1;
    }

    public void Btn_Rolu_Goster_Click()
    {
        tiklamaSayi++;
        if (tiklamaSayi == 1)
        {
            if (oyuncu1 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if(tiklamaSayi == 2)
        {
            LblOyuncuIsmi.text = oyuncu2;
            LblRoluGoster.text = "Rol : ";
            BtnRolGosterGizle.text = "Rol Göster";
        }
        else if(tiklamaSayi == 3)
        {
            if (oyuncu2 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if (tiklamaSayi == 4)
        {
            LblOyuncuIsmi.text = oyuncu3;
            LblRoluGoster.text = "Rol : ";
            BtnRolGosterGizle.text = "Rol Göster";
        }
        else if (tiklamaSayi == 5)
        {
            if (oyuncu3 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if (tiklamaSayi == 6)
        {
            if (oyunKacKisilik == 3)
            {
                //Direk Oyun Bitir Kodları...
                LblRoluGoster.text = "Rol : ";
                ButtonGosterGizle.enabled = false;
                Debug.Log("bitti");
            }
            else
            {
                LblOyuncuIsmi.text = oyuncu4;
                LblRoluGoster.text = "Rol : ";
                BtnRolGosterGizle.text = "Rol Göster";
            }
        }
        else if (tiklamaSayi == 7)
        {
            if (oyuncu4 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if (tiklamaSayi == 8)
        {
            if (oyunKacKisilik == 4)
            {
                //Direk Oyun Bitir Kodları...
                LblRoluGoster.text = "Rol : ";
                ButtonGosterGizle.enabled = false;
                Debug.Log("bitti");
            }
            else
            {
                LblOyuncuIsmi.text = oyuncu5;
                LblRoluGoster.text = "Rol : ";
                BtnRolGosterGizle.text = "Rol Göster";
            }
        }
        else if (tiklamaSayi == 9)
        {
            if (oyuncu5 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if (tiklamaSayi == 10)
        {
            if (oyunKacKisilik == 5)
            {
                //Direk Oyun Bitir Kodları...
                LblRoluGoster.text = "Rol : ";
                ButtonGosterGizle.enabled = false;
                Debug.Log("bitti");
            }
            else
            {
                LblOyuncuIsmi.text = oyuncu6;
                LblRoluGoster.text = "Rol : ";
                BtnRolGosterGizle.text = "Rol Göster";
            }
        }
        else if (tiklamaSayi == 11)
        {
            if (oyuncu6 == vampir)
            {
                LblRoluGoster.text = "Rol : Vampir";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
            else
            {
                LblRoluGoster.text = "Rol : Köylü";
                BtnRolGosterGizle.text = "Rol Gizle";
            }
        }
        else if (tiklamaSayi == 12)
        {
            if (oyunKacKisilik == 6)
            {
                //Direk Oyun Bitir Kodları...
                LblRoluGoster.text = "Rol : ";
                ButtonGosterGizle.enabled = false;
                Debug.Log("bitti");
            }
            else
            {
                LblOyuncuIsmi.text = oyuncu6;
                LblRoluGoster.text = "Rol : ";
                BtnRolGosterGizle.text = "Rol Göster";
            }
        }
    }

    public void Btn_Tartisma_Baslasin_Click()
    {
        Panel_RolleriGoster.SetActive(false);
        Panel_TartismaEkrani.SetActive(true);
        oyunBasladimi = true;
    }

    public void Btn_Oyunu_Bitir_Click()
    {
        sayfa1 = false;
        sayfa2 = false;
        sayfa3 = true;
        sayfa4 = false;
        sayfa5 = false;
        Panel_TartismaEkrani.SetActive(false);
        Panel_OyunuBitir.SetActive(true);
    }

    public void Btn_Oyunu_Bitir_Kontrol_Click(string kontrol)
    {
        if (kontrol == "evet")
        {
            SceneManager.LoadScene("AnaSahne");
        }
        else
        {
            sayfa1 = false;
            sayfa2 = false;
            sayfa3 = true;
            sayfa4 = false;
            sayfa5 = false;
            Panel_TartismaEkrani.SetActive(true);
            Panel_OyunuBitir.SetActive(false);
        }
    }

    public void Btn_Oyuncu_Ele_Click()
    {
        sayfa1 = false;
        sayfa2 = false;
        sayfa3 = false;
        sayfa4 = true;
        sayfa5 = false;
        Panel_TartismaEkrani.SetActive(false);
        Panel_OyuncuEle.SetActive(true);
        if (oyunKacKisilik == 3)
        {
            TxtElemeOyuncu1.text = oyuncu1;
            TxtElemeOyuncu2.text = oyuncu2;
            TxtElemeOyuncu3.text = oyuncu3;
            BtnElemeOyuncu1.SetActive(true);
            BtnElemeOyuncu2.SetActive(true);
            BtnElemeOyuncu3.SetActive(true);
        }
        else if(oyunKacKisilik == 4)
        {
            TxtElemeOyuncu1.text = oyuncu1;
            TxtElemeOyuncu2.text = oyuncu2;
            TxtElemeOyuncu3.text = oyuncu3;
            TxtElemeOyuncu4.text = oyuncu4;
            BtnElemeOyuncu1.SetActive(true);
            BtnElemeOyuncu2.SetActive(true);
            BtnElemeOyuncu3.SetActive(true);
            BtnElemeOyuncu4.SetActive(true);
        }
        else if (oyunKacKisilik == 5)
        {
            TxtElemeOyuncu1.text = oyuncu1;
            TxtElemeOyuncu2.text = oyuncu2;
            TxtElemeOyuncu3.text = oyuncu3;
            TxtElemeOyuncu4.text = oyuncu4;
            TxtElemeOyuncu5.text = oyuncu5;
            BtnElemeOyuncu1.SetActive(true);
            BtnElemeOyuncu2.SetActive(true);
            BtnElemeOyuncu3.SetActive(true);
            BtnElemeOyuncu4.SetActive(true);
            BtnElemeOyuncu5.SetActive(true);
        }
        else if (oyunKacKisilik == 6)
        {
            TxtElemeOyuncu1.text = oyuncu1;
            TxtElemeOyuncu2.text = oyuncu2;
            TxtElemeOyuncu3.text = oyuncu3;
            TxtElemeOyuncu4.text = oyuncu4;
            TxtElemeOyuncu5.text = oyuncu5;
            TxtElemeOyuncu6.text = oyuncu6;
            BtnElemeOyuncu1.SetActive(true);
            BtnElemeOyuncu2.SetActive(true);
            BtnElemeOyuncu3.SetActive(true);
            BtnElemeOyuncu4.SetActive(true);
            BtnElemeOyuncu5.SetActive(true);
            BtnElemeOyuncu6.SetActive(true);
        }
    }

    public void Btn_Oyuncu_Ele_Kontrol_Click(string name)
    {
        if (name == "oyuncu1")
        {
            elenmeDurumuOyuncu = oyuncu1;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        else if(name == "oyuncu2")
        {
            elenmeDurumuOyuncu = oyuncu2;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        else if (name == "oyuncu3")
        {
            elenmeDurumuOyuncu = oyuncu3;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        else if (name == "oyuncu4")
        {
            elenmeDurumuOyuncu = oyuncu4;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        else if (name == "oyuncu5")
        {
            elenmeDurumuOyuncu = oyuncu5;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        else if (name == "oyuncu6")
        {
            elenmeDurumuOyuncu = oyuncu6;
            LblElenmeOyuncusu.text = elenmeDurumuOyuncu;
        }
        Panel_OyuncuEle.SetActive(false);
        Panel_OyuncuEleDetay.SetActive(true);
    }

    public void Btn_Oyuncuyu_Eleme_Butonu_Click()
    {
        BtnElemeDetayGeriDon.SetActive(true);
        if (vampir == elenmeDurumuOyuncu)
        {
            LblElenenRol.text = "Rol : Vampir";
        }
        else
        {
            LblElenenRol.text = "Rol : Köylü";
        }
    }

    public void Btn_Eleme_Detay_Geri_Don()
    {
        Panel_TartismaEkrani.SetActive(true);
        Panel_OyuncuEleDetay.SetActive(false);
        Panel_RastgeleOyuncuEle.SetActive(false);
        
        LblElenenRol.text = "Rol : ";
        sayfa1 = false;
        sayfa2 = false;
        sayfa3 = false;
        sayfa4 = false;
        sayfa5 = false;
    }

    public void Btn_Rastgele_Ele_Click()
    {
        sayfa1 = false;
        sayfa2 = false;
        sayfa3 = false;
        sayfa4 = false;
        sayfa5 = true;
        Panel_TartismaEkrani.SetActive(false);
        Panel_RastgeleOyuncuEle.SetActive(true);
        BtnRastgeleEle.enabled = true;
        LblRastgeleElenen.text = "Elenen Köylü : ";
    }

    public void Btn_Rastgele_Ele_Detay_Click()
    {
        //Rastgele Ele Butonuna Tıklayınca Bir Köylü Eleme...
        int abc = Random.Range(1, oyunKacKisilik + 1);
        if (abc == 1)
        {
            if (vampir == oyuncu1)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu1;
                
            }
        }
        else if(abc == 2)
        {
            if (vampir == oyuncu2)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu2;
            }
        }
        else if (abc == 3)
        {
            if (vampir == oyuncu3)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu3;
            }
        }
        else if (abc == 4)
        {
            if (vampir == oyuncu4)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu4;
            }
        }
        else if (abc == 5)
        {
            if (vampir == oyuncu5)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu5;
            }
        }
        else if (abc == 6)
        {
            if (vampir == oyuncu6)
            {
                Btn_Rastgele_Ele_Detay_Click();
            }
            else
            {
                BtnRastgeleEle.enabled = false;
                LblRastgeleElenen.text = "Elenen Köylü : " + oyuncu6;
            }
        }
    }

}
