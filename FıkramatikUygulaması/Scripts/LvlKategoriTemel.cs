using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlKategoriTemel : MonoBehaviour
{
    public GameObject KategoriCanvas, İcerikCanvas;

    public Text TxtFikraBaslik;
    public InputField TxtFikraIcerik;
    public Text fikraYazi;

    public AudioClip clickSound;
    public AudioSource source;

    void Start()
    {
        KategoriCanvas.SetActive(true);
        İcerikCanvas.SetActive(false);

        source=GetComponent<AudioSource>();
    }

    //İcerik Sayfasından Kategori Sayfasına Geri Dönmeyi Sağlayan Tıklama Olayları...
    public void BtnGeriDonClick()
    {
        KategoriCanvas.SetActive(true);
        İcerikCanvas.SetActive(false);
    }

    //Kategori Sayfasından Ana Menü Sayfasına Geri Dönmeyi Sağlayan Tıklama Olayları...
    public void BtnAnaMenuGeriDon()
    {
        Application.LoadLevel("LvlAnaSayfa");
    }

    //Kategoriler Menüsündeki Butonların Tıklama Olayları...
    public void BtnFikra1Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "YOK MU";
        TxtFikraIcerik.text = "Temel'in Annesi: \n - Vazoyu kim kırdı.\nTemel:\n- Kedi.\nAnnesi :\n - Bizim kedimiz mi var ?\nTemel:\n- Yok mu ?";
        fikraYazi.fontSize = 18;
    }
    public void BtnFikra2Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SEVINEMEMEK";
        TxtFikraIcerik.text = "Temel'in karnesindeki zayıfları gören annesi sinirli sinirli Temel'e bağırır:\n-Ha bu nedur? Geçen yıl sinif birincisudun, bu yıl sonuncu olmişsun!Temel gayet sakin cevaplar:\n-Anacuğum geçen yıl sen çok sevinmiştun bırak bu yıl da başka analar sevinsun da!";
        fikraYazi.fontSize = 24;
    }
    public void BtnFikra3Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SAAT NEDEN GERIDE";
        TxtFikraIcerik.text = "Öğretmeni Temel'e sordu:\n-Söyle bakalım Temel... Amerika'da saatler Avrupa'ya göre neden 5 saat geridir?\nTemel cevabı bilmese de yine hazır cevaplılığını konuşturur:\n -Amerika daha geç keşfedildi da ondan öğretmenum :)";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra4Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "YUZ YIKAMAMAK";
        TxtFikraIcerik.text = "Annesi yeni uyanan Temel'i her zamanki gibi uyardı.-Günaydın uşağum, sofraya oturmadan önce yüzünü yıkıyacasun.Temel boş boş annesinin yüzüne baktı...-Ne oldi niye bakaysun?-Anacuğum biraz önce rüyada suya düştum. Yüzümi yıkamasam olmaz mi?";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra5Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BUYUK LAF";
        TxtFikraIcerik.text = "Misafirlere Temel'in akıllandığını kanıtlamak isteyen babası:\n-Uşağum Temel, hadi emicelerine büyük bi laf et da, senin ne kadar büyuduğuni görsunlar.\nKüçük Temel tek kelimeyle cevap vermiş:-Fil.";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra6Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "KONSERVE DOMATES";
        TxtFikraIcerik.text = "Temel'le Dursun konuşuyorlardı. Dursun Temel'in başındaki şişliği görünce merak edip sordu:-Temel o başindaki şişluk nedu?-Fadime kafama domates atti...-Uyy domates kafa mi şişirur ula?-Konservesi şişiriyi uşağum.";
        fikraYazi.fontSize = 22;
    }
    public void BtnFikra7Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BUKALEMUN";
        TxtFikraIcerik.text = "Temel'e içinde 'bukalemun' kelimesi geçen bir cümle kur demişler.\nTemel'de ,'Ha bu kalemun burda ne işi vardur.' demiş. :)";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra8Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "YALNIZKEN";
        TxtFikraIcerik.text = "Dursun Temel'e:\n-Niyazi yalnizken kendi kendine konuşiyimiş? Öyle mi ula? diye sorar.\nTemel:\n-Ne bileyim uşağum yalnizken yanunda değulum ki.";
        fikraYazi.fontSize = 24;
    }
    public void BtnFikra9Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SINIRLI TEMEL";
        TxtFikraIcerik.text = "Temel Dursun'a fena halde kızar.-Ula inşallah biri hariç bütun dişlerun dökülur!\nDursun anlamaz:-Niye biri kaliyi ula, der.\n-Ağrimasi için!";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra10Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "GOZ AGRISI";
        TxtFikraIcerik.text = "Temel, göz doktoruna gitmiş:\n-Doktor bey, ne zaman çay içsam gözlerum ağriyi, ne yapmam lazim.\nDoktor da Temel'in gözleri muayene etmiş ve:\n-Çayı içmeden önce kaşığı bardaktan çıkartmanız gerekli, demiş.";
        fikraYazi.fontSize = 23;
    }
    public void BtnFikra11Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BENZER KALE";
        TxtFikraIcerik.text = "Temel futbola merak salar ve futbolcu olur. Bir gün maçta teknik direktör ilk yarı sonrası soyunma odasındaki Temel in yanına gidip sorar:-'Neden bizim kaleye gol attın. Olum adam kendi takımının kalesine gol atar mı?'Temel hiç duraksamadan cevap verir :-'Ne yapayum da. Karşı takımın kalesine öyle çok benziy du ki, bizim kale.'";
        fikraYazi.fontSize = 24;
    }
    public void BtnFikra12Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SEKIZ VER SEKIZ";
        TxtFikraIcerik.text = "Of'da bir okulda, matematik öğretmeni öğrencilerine sınav yapmış. Sınav kağıtlarını okumuş, bir öğrenciye yedi puan vermesi gerekmiş, sınav kağıdına 'yedi' mi yoksa 'yeti' mi yazacağına karar verememiş. Bunu bilse bilse Türkçe hocası bilir demiş ve Türkçe hocasına danışmış. Türkçe hocası da düşünmüş,düşünmüş ve;-'Ula hocam, ne tüşüniysun ve peni ne yoriysun! Ver ha ona sekiz!' :)";
        fikraYazi.fontSize = 23;
    }



    void Update()
    {

    }
}
