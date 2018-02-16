using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlKategoriKaradenizScript : MonoBehaviour
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

        source = GetComponent<AudioSource>();
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

        TxtFikraBaslik.text = "AGACLARDAN GOREMIYORUM";
        TxtFikraIcerik.text = "Temelle Dursun ormanda yürüyorlar.Bir ara Temel Dursuna sesleniyor :  -Dursun ormanın güzelliğine bak.  Dursun:  -Ağaçlardan göremiyorumki. ";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra2Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "AKSAM SERINLIGINDE";
        TxtFikraIcerik.text = "Bir mecliste konuşulurken,  Amerikalı  :  -Biz Mars'a gideceğiz, demiş.  Alman :  -Biz yakıtsız giden otomobil üreteceğiz, demiş.  Fransız :  -Atom bombasını etkisiz hale getirecek projelerimiz var, demiş.  Bizim Karadenizli de onlardan geri kalmamak için :  -Biz de güneşe gideceğiz, demiş.  -Güneşe gidemezsiniz, demişler. Güneş yakar. Karadenizli gülümsemiş :  -O kadar da enayi değiliz, tabi, demiş. Akşam serinliğinde gideceğiz. ";
        fikraYazi.fontSize = 21;
    }
    public void BtnFikra3Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ALERJI";
        TxtFikraIcerik.text = "Temel, Cemal'e :  -Fadime'nin kürke alerjisi var.  -Nerden pileysun?  -Ne zaman kürk giymiş pi avrat cörse hastalanayı.  ";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra4Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ANLAMLI ANLAMLI";
        TxtFikraIcerik.text = "Karadenizlinin biri hemşerisine anlatıyor :  -Dün belediye otobüsüne bindim; yan koltuktaki adam bilet almamışım gibi bana anlamlı anlamlı baktı.  -Sen ne yaptın?  -Bende bilet almışım gibi anlamlı anlamlı ona baktım. ";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra5Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ARABAM DISARIDA";
        TxtFikraIcerik.text = "Temel kırtasiye'ye girmiş, tezgahtara :  -Pana pir roman lazum, demiş.  Kırtasiye tezgahtarı sormuş :  -Efendim agır mı olsun hafif mi?  Temel :  -Farketmez, nasul olsa arabam dısarudadur.";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra6Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ARITMETIK";
        TxtFikraIcerik.text = "Aritmetik öğretmeni Temel öğrencilerinden şikayet ediyormuş :  -Derste peş kere peş kaç ediy, diye sorayrum, kırk cevapı alayrum.Halbuki peş kere peş yirmi peş, pilemedun otuz";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra7Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ASANSOR";
        TxtFikraIcerik.text = "Temel kapıcı, çalıştığı on katlı binanın asansörü bozulunca bir kağıt asıyor, üstünde şu yazılar var :  'Asansör pozuk, en yakın asansör yüz metre ileride, yandaki pinadadur'";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra8Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ASMAK";
        TxtFikraIcerik.text = "Dursun evinden çıktığında birde bakar ki komşusu Temel kendini belinden ağaca asmış halde duruyor.Hemen gidip ipi ağaçtan çözer.Komşusunu ağaçtan indirdikten sonra merakla sorar :  -Ha sen ne yapayudun öyle?  -Hiç kendimi asaydum...  -Ha uşağum, penum pildiğum insan poynundan asılayi.  Temel üzgün ve çaresiz bir halde komşusu Dursun'a baktıktan sonra cevap verir :  -Ben de öyle yapmişudum.Ama ipu poynima pağladığum zaman bi türlü nefes alamayrum";
        fikraYazi.fontSize = 18;
    }
    public void BtnFikra9Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "AT YARISI";
        TxtFikraIcerik.text = "At yarışına merak saran Temel bir gün hipordroma gider. Yalnız önünde delicesine bir o yana bir bu yana koşan atlara akıl erdiremez ve dayanamayarak yanındakine sorar. -Hah hemşerim bu atlar ne deli gibi koşup duruyor. Adam da : -1. olana ikramiye var da ondan, der. Temel de cevap vererek : -Hah 1. olana para varda ötekiler niye koşup duruyor. ";
        fikraYazi.fontSize = 23;
    }
    public void BtnFikra10Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "AYAKKABI";
        TxtFikraIcerik.text = "Temel işe girmek için sözlü sınava giriyor.Çok heyecanlı, bir önceki adaya soruyor :  -Ne sorayiler?  -Ayakkabı.  Temel'in sırası geliyor, bilsin diye kolay soruyorlar :  -Dört ayaklıdır, miyav miyav der.  Temel soruyor :  -Bağcıkli midur? ";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra11Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BENDE TUTULDUM";
        TxtFikraIcerik.text = "Doktor Temel hastasına sorar :  -Verdiğim ilaçlar iyi geldi mu?  Hasta :  -Neden sordun?  Temel :  -Aynı hastaluğa pende tutildum da ondan.  ";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra12Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BIYIK";
        TxtFikraIcerik.text = "Karadeniz'i gezmekte olan turist :  -Allah Allah, burada herkesin bıyığı var, demiş.  Temel, burnuna dikkat çekerek :  -Piz önemli ve değerli şeylerin altini çizeruz. ";
        fikraYazi.fontSize = 25;
    }



    void Update()
    {

    }

}
