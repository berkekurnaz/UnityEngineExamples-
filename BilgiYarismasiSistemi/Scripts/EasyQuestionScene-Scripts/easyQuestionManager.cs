using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class easyQuestionManager : MonoBehaviour
{

    public GameObject CnvQuestion;
    public GameObject CnvGameOver;
    public GameObject CnvPauseMenu;

    public Text TxtTime;
    public Text TxtScore;

    public Text TxtQuestion;
    public Text TxtAnswer1;
    public Text TxtAnswer2;
    public Text TxtAnswer3;
    public Text TxtAnswer4;

    public Button BtnAnswer1;
    public Button BtnAnswer2;
    public Button BtnAnswer3;
    public Button BtnAnswer4;

    public int number;
    public int score;
    float time_f;
    int time_i;

    public bool click;

    public string trueAnswer;

    public Text TxtBittiDurum;
    public Text TxtBittiPuan;
    public Text TxtBittiSure;
    public Text TxtBittiDogruSayisi;

    public AudioSource source;
    public AudioClip trueSound;
    public AudioClip falseSound;

    void Start()
    {
        source = GetComponent<AudioSource>();

        /*Oyun Basinda Soru Ekrani Acik,Bitis Ekrani Kapali Durumda*/
        CnvQuestion.SetActive(true);
        CnvGameOver.SetActive(false);
        CnvPauseMenu.SetActive(false);

        TxtTime.text = "99";
        TxtScore.text = "000";

        score = 000;
        time_f = 99;

        CreateQuestion();
    }

    void FixedUpdate()
    {

        /*Kalan Surenin Azalmasi Ile Ilgili Kodlar*/
        time_f = time_f - Time.deltaTime;
        time_i = (int)time_f;
        TxtTime.text = time_i.ToString();
        if(time_f <= 0)
        {
            Debug.Log("Oyun Bitti");
            GameOver();
        }

        /*Geri Tusuna Basinca Gerceklesecek Olaylar*/
        if(Input.GetKey(KeyCode.Escape))
        {
            CnvGameOver.SetActive(false);
            CnvPauseMenu.SetActive(true);
        }

    }



    /*A Butonuna Tıklama Olayları*/
    public void Answer1()
    {
        if(TxtAnswer1.text == trueAnswer)
        {
            click = true;
            TrueSoundEffect();
            score = score + 10; //Skor 10 Arttı...
            TxtScore.text = score.ToString(); //Skoru Ekrana Yazdırdık...
            time_f = time_f + 5f;
            time_i = (int)time_f;
            TxtTime.text = time_i.ToString();
            BtnAnswer1.GetComponent<Image>().color = Color.green;
            if(click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("CreateQuestion", 1f); //1 Saniye Sonra Yeni Soru Ve Cevap Oluşturuldu...
        }
        else
        {
            click = true;
            FalseSoundEffect();
            BtnAnswer1.GetComponent<Image>().color = Color.red;

            if (TxtAnswer2.text == trueAnswer)
            {
                BtnAnswer2.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer3.text == trueAnswer)
            {
                BtnAnswer3.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer4.text == trueAnswer)
            {
                BtnAnswer4.GetComponent<Image>().color = Color.green;
            }

            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("GameOver", 2f);
        }
    }



    /*B Butonuna Tıklama Olayları*/
    public void Answer2()
    {
        if (TxtAnswer2.text == trueAnswer)
        {
            click = true;
            TrueSoundEffect();
            score = score + 10; //Skor 10 Arttı...
            TxtScore.text = score.ToString(); //Skoru Ekrana Yazdırdık...
            time_f = time_f + 5f;
            time_i = (int)time_f;
            TxtTime.text = time_i.ToString();
            BtnAnswer2.GetComponent<Image>().color = Color.green;
            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("CreateQuestion", 1f); //1 Saniye Sonra Yeni Soru Ve Cevap Oluşturuldu...
        }
        else
        {
            click = true;
            FalseSoundEffect();
            BtnAnswer2.GetComponent<Image>().color = Color.red;

            if(TxtAnswer1.text == trueAnswer)
            {
                BtnAnswer1.GetComponent<Image>().color = Color.green;
            }
            else if(TxtAnswer3.text == trueAnswer)
            {
                BtnAnswer3.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer4.text == trueAnswer)
            {
                BtnAnswer4.GetComponent<Image>().color = Color.green;
            }

            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("GameOver", 2f);
        }
    }



    /*C Butonuna Tıklama Olayları*/
    public void Answer3()
    {
        if (TxtAnswer3.text == trueAnswer)
        {
            click = true;
            TrueSoundEffect();
            score = score + 10; //Skor 10 Arttı...
            TxtScore.text = score.ToString(); //Skoru Ekrana Yazdırdık...
            time_f = time_f + 5f;
            time_i = (int)time_f;
            TxtTime.text = time_i.ToString();
            BtnAnswer3.GetComponent<Image>().color = Color.green;
            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("CreateQuestion", 1f); //1 Saniye Sonra Yeni Soru Ve Cevap Oluşturuldu...
        }
        else
        {
            click = true;
            FalseSoundEffect();
            BtnAnswer3.GetComponent<Image>().color = Color.red;

            if (TxtAnswer1.text == trueAnswer)
            {
                BtnAnswer1.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer2.text == trueAnswer)
            {
                BtnAnswer2.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer4.text == trueAnswer)
            {
                BtnAnswer4.GetComponent<Image>().color = Color.green;
            }

            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("GameOver", 2f);
        }
    }



    /*D Butonuna Tıklama Olayları*/
    public void Answer4()
    {
        if (TxtAnswer4.text == trueAnswer)
        {
            click = true;
            TrueSoundEffect();
            score = score + 10; //Skor 10 Arttı...
            TxtScore.text = score.ToString(); //Skoru Ekrana Yazdırdık...
            time_f = time_f + 5f;
            time_i = (int)time_f;
            TxtTime.text = time_i.ToString();
            BtnAnswer4.GetComponent<Image>().color = Color.green;
            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("CreateQuestion", 1f); //1 Saniye Sonra Yeni Soru Ve Cevap Oluşturuldu...
        }
        else
        {
            click = true;
            FalseSoundEffect();
            BtnAnswer4.GetComponent<Image>().color = Color.red;

            if (TxtAnswer1.text == trueAnswer)
            {
                BtnAnswer1.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer2.text == trueAnswer)
            {
                BtnAnswer2.GetComponent<Image>().color = Color.green;
            }
            else if (TxtAnswer3.text == trueAnswer)
            {
                BtnAnswer3.GetComponent<Image>().color = Color.green;
            }

            if (click == true)
            {
                BtnAnswer1.enabled = false;
                BtnAnswer2.enabled = false;
                BtnAnswer3.enabled = false;
                BtnAnswer4.enabled = false;
            }
            Invoke("GameOver", 2f);
        }
    }




    /*Yanlis Cevap Verince Oyun Bitti Ekrani Gelmesi*/
    void GameOver()
    {
        /*Kullanicinin Cevabi Ile Dogru Cevap Ayni Degil Ise Soru Ekrani Kapali,Bitis Ekrani Acik Durumda*/
        CnvQuestion.SetActive(false);
        CnvGameOver.SetActive(true);

        /*İstatistiklerin Ekrana Yazdırılması*/
        TxtBittiPuan.text = score.ToString();
        TxtBittiSure.text = time_i.ToString();
        TxtBittiDogruSayisi.text = (score / 10).ToString();
        if(score>=100)
        {
            TxtBittiDurum.text = "Güzel Bir Yarisma Oldu...";
        }
        else if(score>=300)
        {
            TxtBittiDurum.text = "Harika Bir Yarisma Oldu...";
        }
        else
        {
            TxtBittiDurum.text = "Biraz Daha Kendini Gelistirmen Gerekiyor...";
        }
    }



    /*BtnRestart Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnRestartGameClick()
    {
        SceneManager.LoadScene("EasyQuestionScene");
    }

    /*BtnMainMenu Adli Butona Tiklayinca Gerceklesecek Olaylar*/
    public void BtnMainMenuClick()
    {
        SceneManager.LoadScene("MainScene");
    }



    /*Dogru Cevap Verdigimizde Calacak Ses*/
    void TrueSoundEffect()
    {
        source.PlayOneShot(trueSound);
    }

    /*Yanlis Cevap Verdigimizde Calacak Ses*/
    void FalseSoundEffect()
    {
        source.PlayOneShot(falseSound);
    }



    /*Mola Menusunde Evet Tusuna Basilmasi Olaylari*/
    public void BtnMenuYesClick()
    {
        SceneManager.LoadScene("MainScene");
    }

    /*Mola Menusunde Hayir Tusuna Basilmasi Olaylari*/
    public void BtnMenuNoClick()
    {
        CnvGameOver.SetActive(false);
        CnvPauseMenu.SetActive(false);
    }



    /*Soru Olusturucu*/
    void CreateQuestion()
    {
        click = false;

        BtnAnswer1.enabled = true;
        BtnAnswer2.enabled = true;
        BtnAnswer3.enabled = true;
        BtnAnswer4.enabled = true;

        BtnAnswer1.GetComponent<Image>().color = Color.white;
        BtnAnswer2.GetComponent<Image>().color = Color.white;
        BtnAnswer3.GetComponent<Image>().color = Color.white;
        BtnAnswer4.GetComponent<Image>().color = Color.white;

        number = Random.Range(0, 5);

        if(number == 0)
        {
            TxtQuestion.text = "Soru : Türkiye'nin Başkenti Neresidir ?";
            TxtAnswer1.text = "Ankara";
            TxtAnswer2.text = "İstanbul";
            TxtAnswer3.text = "Bursa";
            TxtAnswer4.text = "Balıkesir";
            trueAnswer = "Ankara";
        }
        else if(number == 1)
        {
            TxtQuestion.text = "Soru : Alfabemizin İkinci Harfi Nedir ?";
            TxtAnswer1.text = "A";
            TxtAnswer2.text = "B";
            TxtAnswer3.text = "C";
            TxtAnswer4.text = "D";
            trueAnswer = "B";
        }
        else if (number == 2)
        {
            TxtQuestion.text = "Soru : TBMM Kaç Yılında Açılmıştır ?";
            TxtAnswer1.text = "1919";
            TxtAnswer2.text = "1920";
            TxtAnswer3.text = "1923";
            TxtAnswer4.text = "1925";
            trueAnswer = "1920";
        }
        else if (number == 3)
        {
            TxtQuestion.text = "Soru : Futbol Toplam Kaç Kişi İle Oynanır ?";
            TxtAnswer1.text = "20";
            TxtAnswer2.text = "21";
            TxtAnswer3.text = "22";
            TxtAnswer4.text = "24";
            trueAnswer = "22";
        }
        else if (number == 4)
        {
            TxtQuestion.text = "Soru : Bakü Hangi Devletin Başkentidir ?";
            TxtAnswer1.text = "Türkmenistan";
            TxtAnswer2.text = "Gürcistan";
            TxtAnswer3.text = "Kırgızistan";
            TxtAnswer4.text = "Azerbaycan";
            trueAnswer = "Azerbaycan";
        }
    }
}
