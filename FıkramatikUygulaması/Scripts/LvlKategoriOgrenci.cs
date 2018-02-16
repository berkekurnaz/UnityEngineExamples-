using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlKategoriOgrenci : MonoBehaviour
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

        TxtFikraBaslik.text = "HAYVANOGLU HAYVAN";
        TxtFikraIcerik.text = "Bir gün bir sınıfa yeni gelen öğretmen tanışma faslında ismini söyler:-Çocuklar benim adım Aslan Aslanoğlu der.Öğretmen sınıfa birdahaki girişinde öğrenciye sorar:-Söyle bakalım evladım benim adım neydi?Öğrenci cevap verir:Hocam valla bi hayvanoğlu hayvandı ama hangi hayvandı bilmiyorum.:))";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra2Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "IMZA";
        TxtFikraIcerik.text = "- Babacığım, karanlıkta yazı yazabilir misin?- Sanırım yazabilirim. Ne yazmamı istersin?- Karneme adını yazıp imza atar mısın!";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra3Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BABAN HAZIR";
        TxtFikraIcerik.text = "Karnesini olan Mert ilk iş olarak telefona sarıldı. Karşısındaki annesiydi;'Anneciğim!' dedi. 'Çok üzgünüm, sınıfta kaldım. Ben gelinceye kadar babamı bu durum için hazırlar mısın?'Osman’ın annesi;'Oğlum!' dedi. 'Baban hazır, asıl sen kendini hazırla!'";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra4Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "HATA";
        TxtFikraIcerik.text = "Hoca matematik dersinde bir problem sorar Ali parmak kaldırır fakat soruyu yanlış yapar.Hoca sınıfa dönerek evet çocuklar arkadaşınızın ilk hatası neydi emre cevap verir- 'Parmak kaldırmasıydı hocam' der.";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra5Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "OKUL MUDURU";
        TxtFikraIcerik.text = "Bir gün okul müdürünün telefonu çalar. Müdür telefonu açar _buyrun?-müdür bey benim çocuğum bugün okula gelmeyecek ,biraz rahatsızlandı.-peki kimsiniz?-'ben mi?'der çocuk ve devam eder ben babam.:)";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra6Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "KARA BULUTLAR";
        TxtFikraIcerik.text = "Öğretmen Hayat Bilgisi dersinde bulutların yeryüzündeki suların buharlaşmasından oluştuğunu uzun uzun anlattıktan sonra ön sıralarda oturan öğrencilerden birine şu soruyu sordu :- Söyle bakalım oğlum, kara bulutlar neden olur?Çocuk düşündü , yutkundu, bir şey diyemedi. Onun yanında oturan küçük kız çocuğu parmak kaldırarak şu cevabı verdi :- Kirli sulardan olur öğretmenim!..";
        fikraYazi.fontSize = 22;
    }
    public void BtnFikra7Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "HANGI DISLER";
        TxtFikraIcerik.text = "öğretmen öğrencilerine sordu:-Söyleyin bakalım, en son hangi dişler çıkar?Sınıfta bir sessizlik oldu, sınıfın en arkasından bir el kalktı:-Ben biliyorum öğretmenim!-Söyle bakalım!-En son takma dişler çıkar öğretmenim!…";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra8Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BABASI DAVA ACMAZ";
        TxtFikraIcerik.text = "Müfettiş, öğretmeni bir öğrenciyi fena halde döverken yakalamıştı. Derhal uyardı. – Ne yapıyorsunuz hocam, biliyorsunuz ki dövmek yasak! Babası size dava açsa başınıza bela alır, uğraşıp durusunuz? – Babasının dava açmayacağına garanti veririm!… Müfettiş şaşırdı. Öğretmen açıklamaya devam etti: – Babası benim!…";
        fikraYazi.fontSize = 24;
    }
    public void BtnFikra9Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "DILENCININ TORBASI";
        TxtFikraIcerik.text = "Okuldan eve dönen çocuklar kocaman torbalı dilenciyi görünce onu eve çağırıp evde ne buldularsa torbasının içine doldurmaya başlarlar. Dilenci olan biteni şaşkınlıkla seyrederken anneleri gelir hayretler içinde “Ne yapıyorsunuz?!” diye bağırır.Çocuklar: -Deneme yapıyoruz, derler. -Ne denemesi? -Sen, ne koyarsanız koyun dilencinin torbası dolmaz demiştin ya anne. Doğru söyleyip söylemediğini anlamaya çalışıyoruz.";
        fikraYazi.fontSize = 21;
    }
    public void BtnFikra10Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SOMUN EKMEK";
        TxtFikraIcerik.text = "Küçük Johnny,bir elinde bir somun ekmek, diğer eli cebinde, bakkaldan gelirken köyün rahibi ona dini bir takım dersler verebilmek için yolunu kesmiş, “Biliyorsun değil mi Johnny” demiş “Hepimiz elinde tuttuğun şey için yaşıyoruz, onun için gece gündüz didiniyoruz evladım Peki, öbür elinde ne var bakalım?” “Şeyy” demiş küçük Johnny biraz şaşırarak, “Bir somun ekmek efendim!”";
        fikraYazi.fontSize = 23;
    }
    public void BtnFikra11Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ARI SOKMASI";
        TxtFikraIcerik.text = "Öğrenci derse geç kalmıştı. Öğretmen niye geç kaldığını sordu. Öğrenci “Arı soktu” dedi. Öğretmen: “Nereni soktu?” Öğrenci: “Söyleyemem.” Öğretmen kızdı, “Otur!” diye bağırdı. Öğrenci boynunu bükerek cevap verdi: “Oturamam!”";
        fikraYazi.fontSize = 27;
    }
    public void BtnFikra12Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BEYAZ GELINLIK";
        TxtFikraIcerik.text = "Öğretmen sınıfa soru sordu: “Düğünlerde gelinler neden beyaz giyer bilir misiniz? Bu onların en mutlu günü olduğu için! ” Arka sıralardan bir ses yükselir; “Damatların neden siyah elbise giydiklerini şimdi anladım hocam.”";
        fikraYazi.fontSize = 28;
    }



    void Update()
    {

    }
}
