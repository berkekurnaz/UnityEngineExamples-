using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlKategoriAvciScript : MonoBehaviour
{
    public GameObject KategoriCanvas, İcerikCanvas;

    public Text TxtFikraBaslik;
    public InputField TxtFikraIcerik;

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

        TxtFikraBaslik.text = "AYI";
        TxtFikraIcerik.text = "Adamın biri eski bir macerasını kahvede arkadaşlarına anlatıyordu.Macera şöyleydi:-'Ben dağa çıkmıştım.Önüme bir anda kocaman bir ayı çıktı.Ben kaçmaya başladım.Ayı beni kovalıyor ve bana daha çok yaklaşıyordu.Ayı tam pençeyi yapıştırcak ,kayıp düşüyordu.Bu 2-3 kez oldu böyle.Kahve de oturan adamlardan biri şöyle dedi:'Abi ben olsam altıma yapardım.Adam cevap verir.-'Lan ayıoğlu ayı, ayı neye basıpta düşüyor sanıyorsun!!!";
    }
    public void BtnFikra2Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "HIZLI KOSU";
        TxtFikraIcerik.text = "Bir Amerikali ile Japon safari'ye çıkmışlar.Her ikisi de son teknolojik silahları ile birbirlerine nazire yapmak için yanlarına almışlar. Derken uzakta bir aslan görünmüş. Amerikalı lazer tüfeğini doğrultmuş ve aslana ateş etmiş. Ama karavana.Hemen Japon uydudan yönlendirmeli tüfeğini doğrultup ateş etmiş. Fakat o da karavana.Aslan bizimkileri farkedince üzerlerine doğru gelmeye başlamış. Amerikalı bir yudum viski içip acı sonu beklemeye başlamış. Japon hemen botlarını çıkarıp spor ayakkabılarını giymeye başlamış.Amerikalı sormuş : -Ne o, aslandan hizlı mı koşacaksın ? -Yoo, senden hızlı koşsam yeter...";
    }
    public void BtnFikra3Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BOZ KARTAL";
        TxtFikraIcerik.text = "Milli Park Polisleri, adamın birini, nesli tükenmekte olduğu için koruma altına alınan bir Boz Kartal'ı kesmiş, pişirip yerken görmüş ve derhal tutuklamışlar...Mahkemede adamın avukatları müthiş bir savunma yapmışlar:- Bu adam ormanda yolunu kaybetmişti. Günlerdir aç olduğu için ya kartalı öldürecekti, ya kendisi ölecekti.Yargıç bu savunmayı kabul edebileceğini söylemiş. Kararını açıklamadan önce, sanığa dönmüş: - Son bir şey sormak istiyorum. Ben de av meraklısıyım da.. Bu Boz Kartalın tadı nasıl bir şey?- Valla efendim! Tam olarak Kelaynak ile Mavi Gagalı Puhu Kuşu tatlarının arasında bir şey..!";
    }
    public void BtnFikra4Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "KORKAK AVCI";
        TxtFikraIcerik.text = "Mahalledeki mısırlara dadanan domuzu avlamak için Hamza Dayı bir avcı gurubu oluşturmuş.Görev bölümünden sonra pusuya yatmışlar. Hamza Dayı gelen sese doğru tüfeğini doğrultmuş. Dikkatle bakarken önünden geçen domuzun boynuna Hamza Dayı'nın tüfeği takılmış. Panikleyen Hamza Dayı kaçmaya başlamış. Arkadaşlarına:'Kaçın arkadaşlar '!!!!! 'Tüfek elinde domuz geliyor.'";
    }
    public void BtnFikra5Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "KIZILDERELI AVI";
        TxtFikraIcerik.text = "Eski bir zamanda işsiz olan Temel ile Dursun Amerika'ya gidip iş bulmaya karar verirler. Kasabada gezinirken gözlerine bir afiş takılır. Afişte:'Kızılderili kafa derisi getirene 100 dolar' yazmaktadır. Bunu gören Temel ve Dursun sevinerek hemen işe koyulur. Bütün gün ormanda kızılderili arayıp bulamayan Temel ile Dursun çadır kurup bir sonraki gün aramaya devam etmeye karar verirler. Yorgun düşen bizim ikili hemen uykuya dalarlar. Temel birden çadırın dışından gelen seslerle uyanır. Çadırı aralayarak dışarı baktığında ne görsün, çadırın etrafını kızılderililer sarmıştır. Hemen Dursunu uyandırır. Ve derki:-- Ula Dursun, uyan len uyan, şimdi parayı kırduk...";
    }
    public void BtnFikra6Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "ACEMI OKCU";
        TxtFikraIcerik.text = "Bir filozof kırda tek başına giderken uzaktan acemi ve cahil bir okçu gördü. Oku hedefe nişanlıyor ama hep karavana atıyordu. Filozof oka hedef olmaktan korktuğu için gidip okçunun hedefine oturdu ve:-Buradan daha emin bir yer olamaz. Çünkü okun hedefini bulmayacağından eminim!";
    }
    public void BtnFikra7Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BIR ASLAN ICIN";
        TxtFikraIcerik.text = "Avcının biri palavra sıkıyormuş:-Geçen yaz Afrika'da 99 aslan vurdum...Arkadaşı dayanamamış:-100 de şuna bari demiş . Avcı da :-Bir aslan için yalan mı söyleyeceğim sana ..! demiş.";
    }
    public void BtnFikra8Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "GEYIK AVI";
        TxtFikraIcerik.text = "Temel ile Dursun bir gün ava gitmişler. İri bir geyik avlayıp geri dönerlerken çok ağır olan geyiği birer boynuzundan beraberce tutarak köylerine doğru yola koyulmuşlar. Köye beşyüz metre kala köyün yaşlılarından biri ile karşılaşmışlar.Adam geyiği görüp Temel ile Dursun'u tebrik ettikten sonra, geyiği böyle taşımaları halinde etinin sertleşeceğini söyleyerek kuyruğundan çekerek taşımalarını önermiş. Temel ile Dursun da kuyruğundan çekerek taşımaya başlamışlar. Bir süre sonra çok yorulmuşlar ve Dursun Temel'e dönüp : - 'Ula Temel biz yine eskisi gibi taşısak iyi olur. Baksana köyden epeyce uzaklaştık'";
    }
    public void BtnFikra9Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BENDEN MISIN";
        TxtFikraIcerik.text = "Temel bir gün av hikayelerini anlatırken dursun demişki : -Ula temel önüne bi tilki çıksa ne yaparsın ?Temel :-Silahımla vururum . demiş.Dursun :-Silahın yok o zaman ne yaparsın .Temel :-Çıkarır palayla doğrarım . demiş .Dursun :-O da yok .Temel :-O zaman bıçağımla doğrarım . demiş .Dursun :-Oda yoktur sonra ne yapacaksın ?Temel düşünmüş ve demiş ki :-Ula uşağum sen benden yanamısın yoksa tilkiden yanamısın ?";
    }
    public void BtnFikra10Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "SADIK";
        TxtFikraIcerik.text = "Bir AVCI diğerine sordu: Köpeğinizi satın almak istiyorum ama sadık mıdır? -Hem de fazlasıyla sadık. Size bu konuda yüzde 100 garanti verebilirim. -Nasıl bu kadar emin olabilirsiniz? Şimdiye kadar 5 kere sattım. Her seferinde de geri geldi.";
    }
    public void BtnFikra11Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "BENIM KOPEK";
        TxtFikraIcerik.text = "Malum, avcılar atıcılıklarıyla meşhurdurlar. Yine bir mecliste üç avcı karşılıklı olarak köpeklerini övüyorlarmış. Birincisi demiş ki:'Benim köpeğim çok akıllıdır, bakkala gönderirim, ne istersem alır ve getirir.' Hemen ikinci avcı atlamış:' Ya benimki! Sadece istediklerimi almakla kalmaz, paranın üstünü de doğru olarak getirir, satış fişini de alır vs. vs. Bu sırada üçüncü avcı kendinden emin bir tavırla aynen şöyle der:'Sizin köpeklerinizin alışveriş ettiği dükkanı benim köpeğim çalıştırıyor.'";
    }
    public void BtnFikra12Click()
    {
        KategoriCanvas.SetActive(false);
        İcerikCanvas.SetActive(true);

        source.PlayOneShot(clickSound); /*Tıklama Olayı Gerçekleşince Çıkacak Ses Kodu*/

        TxtFikraBaslik.text = "TAMAMDIR";
        TxtFikraIcerik.text = "İskoçyada iki avcı ava çıkarlar.Yürüme esnasında avcılardan biri yere düşer ve hareketsiz olarak yatar.Bunu gören arkadaşı hemen yanına gelir bakarki arkadaşı nefes almıyor,gözlerin deki ferin dekaybolduğunu farkeder ve hemen acil sevisi arar.Arkadaşım öldü,der neyapmam gerekir diye sorar.Telefonun ucundaki ses:-'Sakin olun ben size yardım edebilirim ama önce arkadaşının öldüğünden emin olmamız gerek'der,ve birkaç saniye sessizlikten sonra bir el silah sesi duyulur.Sonra:-'Tamam şimdi ne yapacağım'";
    }



    void Update()
    {

    }
}
