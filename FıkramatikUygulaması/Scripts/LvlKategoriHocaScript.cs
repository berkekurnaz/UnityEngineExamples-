using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlKategoriHocaScript : MonoBehaviour
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

        TxtFikraBaslik.text = "ACEMI BULBUL";
        TxtFikraIcerik.text = "Nasrettin Hoca bir gün komşusunun bahçesine girer. Bahçedeki armutları görünce dayanamaz. Bir tane yer, dayanamaz bir daha, bir daha derken armut ağacına çıkıverir. Başlar yemeye. Tam bu sırada bahçenin sahibi çıkagelir.Hoca şaşkınlıkla başlar bülbül gibi ötmeye.Bahçenin sahibi şaşkın şaşkın Hocanın olduğu ağacın yanına varıp,- Ne yapıyorsun burada diye bağırır.Hoca sakince cevap verir.- Ben bülbülüm, yuvam da burada, der.Tekrar cırlak sesiyle ötmeye başlar.Bahçe sahibi öfkeyle- Bülbül böylemi öter be adam diye bağırınca,Hoca- Ben acemi bülbülüm. Ancak bu kadar ötüyorum, der.";
        fikraYazi.fontSize = 18;
    }
    public void BtnFikra2Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ATES DUSTUGU ZAMAN";
        TxtFikraIcerik.text = "Nasreddin Hoca'nın evine tüccar arkadaşı misafir olmuş. Hoca ona mantı pişirip getirmiş. Arkadaşı acele edip mantıyı hemen ağzına atınca boğazı yanmış. Boğazının yandığını belli etmemek için başını tavana doğru dikmiş ve yanmanın etkisi gidince de başını tavandan indirmeyip sormuş:- Hocam bu tavanı ne zaman yaptınız.Hoca hemen:- Boğazına ateş düştüğü zaman, demiş.";
        fikraYazi.fontSize = 21;
    }
    public void BtnFikra3Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BEN UYUYORUM";
        TxtFikraIcerik.text = "Bir gün Nasreddin Hoca şehre gelip, bir arkadaşıyla birlikte handa kalmış. Gece yarısı arkadaşı sormuş:- Hocam, uyudunuz mu?- Buyurun birşey mi var?- Biraz borç para isteyecektim.Nasreddin Hoca derhal horlamaya başlayıp:- Ben uyuyorum! demiş.";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra4Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BIZDE KIBIR YOK";
        TxtFikraIcerik.text = "Nasreddin Hoca'ya yapilan şakalar tükenip bitmezdi. Akşehir'liler bir gun Hoca'ya takilir ve sorarlar.- Hocam senin evliyalar katında ulu bir kişi olduğun söylenir, aslı var mıdır?Hoca'nın boyle bir iddiasi elbette yoktur, ama bir kere soruldu ya cevaplar;- Her halde öyle olmalı.- Böyle kişiler zaman zaman mucizeler göstererek bu özelliklerini herkese kanıtlar. Hoca madem kabullendin goster bir mucize gorelim!Hoca;- Pekala simdi size bir numara yapalim der, karşısında durmakta olan çınar ağacına;- Ey ulu çınar çabuk yanıma gel!...Tabii ne gelen ağac var ne giden. Hoca yürümeye başlar ağacın yanına varır. Akşehir'liler;- Ne oldu Hoca ağacı getiremedin, kendin oraya gittin! diye gülünce,Hoca;- Bizde kibir yoktur, dağ yürümezse abDal yürür der.";
        fikraYazi.fontSize = 16;
    }
    public void BtnFikra5Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "DUNYANIN MERKEZI";
        TxtFikraIcerik.text = "Bir gün köyün gençleri Hocayı sınavdan geçirmeye karar vermişler. Köyün alanında toplanıp Hoca'nın yolunu beklemişler. Biraz sonra Hoca çıkmış karşılarına. İçlerinden bilgi bakımından kendine güvenen biri:- Hocam sana bir soru soracağım. Bakalım bilecek misin?Hoca da sor bakalım demiş.Delikanlı sormuş;- Dünya'nın merkezi neresidir?Hoca anında yanıtlamış;- Ayağımın bastığı yerin altındadır. Çocuklar ne diyeceklerini bilemeden dağılmışlar.";
        fikraYazi.fontSize = 20;
    }
    public void BtnFikra6Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "CIMRI VE NASRETTIN HOCA";
        TxtFikraIcerik.text = "Cimri ve de boş boğazın biri Hocaya:Ya Nasrettin Hoca demiş demek parayı çok seviyorsun. Acaba neden?- Hoca cevabını yapıştırmış. Senin gibilere muhtaç olmamak için...";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra7Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "HIRSIZ";
        TxtFikraIcerik.text = "Nasrettin hoca bir gün namaz kılarken evine hırsız girmiş;Tam hocanın cüzdanını çalacakken, Nasrettin Hoca:Gul hüveallahü felak, arkamdaki salak, hemen cüzdanımı bırak, otur da namaz kılak :))";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra8Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "9 AKCE MI 10 AKCE MI";
        TxtFikraIcerik.text = "Bir gün Nasreddin Hoca rüyasında bir adamla konuşuyormuş, adam 9 akçe diyormuş. Nasreddin Hoca da 10 akçe diyormuş.Nasreddin hoca rüyadan uyanmış ellerinde hiç akçe yok.Geri uykuya dalmış ve adama demiş tamam 9 akçe olsun.";
        fikraYazi.fontSize = 18;
    }
    public void BtnFikra9Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SAKADAN HOSLANMAM";
        TxtFikraIcerik.text = "Nasrettin Hoca pazarda dalgın yürüyormuş. Etrafındaki esnafları seyrediyormuş. Bu sırada ensesine bir tokat geliyor. Hoca tökezlemiş bir kaç adım sendelemiş neyse toparlanıp sinirli bir şekilde arkasını dönmüş.Bir bakmış ki hocanın 2 katı hayvan gibi bir adam. Hoca durmuş bir yutkunmuş önce, sonra:- Bana sen mi vurdun? demiş adama.Adam:- Ben vurdum lan ne olacak demiş.Hoca:- Şakadan mı vurdun, ciddiden mi? demişAdam:- Ciddi vurdum napacan?!Hoca:- Aman aman, öyle olsun, Çünkü şakadan hiç hoşlanmam da!!!";
        fikraYazi.fontSize = 18;
    }
    public void BtnFikra10Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SOYLE BARI";
        TxtFikraIcerik.text = "Hoca ormana gitmiş.Oturmuş bir dalın üstüne, başlamış kesmeye.Aşağıdan geçen bir yolcu Hoca'ya seslenmiş :- Be adam! İnsan oturduğu dalı keser mi ?Şimdi düşeceksin.Hoca adama aldırmamış; işine devam etmiş.Az sonra dal kırılmış. Hoca, cumburlop düşmüş.Düştüğü yerden perişan seslenmiş:- Düşeceğimi bildin ne zaman öleceğimi de söyle bari.";
        fikraYazi.fontSize = 20;
    }
    public void BtnFikra11Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "TESPIH";
        TxtFikraIcerik.text = "Nasreddin Hoca evde tespihini kaybetmiş. Bakmış ki ev zifiri karanlık, tespihini sokakta aramaya başlamış. Hoca'nın yerde bir şey aradığını görenler:- Hayırdır Hoca, ne arıyorsun?– Evde tespihimi kaybettim, onu arıyorum.– İlahi Hoca, evde neden aramıyorsun?– Ne yapayım? Orası karanlık!";
        fikraYazi.fontSize = 25;
    }
    public void BtnFikra12Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "AKLINI KAYBETMIS";
        TxtFikraIcerik.text = "Hoca, uzun bir süre Bursa'da kalıp Akşehir'e dönerken, yolda konu komşu:- Ah Hocam, karın aklını kaybetti, demişler.Hoca, hiç oralı olmamış. Ah, vah bile dememiş.Bu sefer:- Hocam, anlamadın herhalde, diye, şaşırmışlar.Nasreddin Hoca:– Anladım, anladım da. Anlamadığım; zaten yoktu ki olmayan bir şeyi nasıl kaybetti!";
        fikraYazi.fontSize = 20;
    }



    void Update()
    {

    }
    
}
