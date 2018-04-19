# Bilgi Yarışması Sistemi 

Unity 2017 Oyun Motoru ve C# Programlama Dili İle Hazırlanmış Temel Bilgi Yarışması Oyunu Sistemidir...

### Nasıl Kullanırım?

Dosyaları İndirip Projenizin İçine Yükleyin...

### Kullanım Ve Özellikler

Oyun 'easyQuestionManager.cs' nin En Altında Bulunan CreateQuestion Fonksiyonunun İçinde Yazılmış 5 Sorudan Birini Rastgele Bize Getirir. Buradaki Soruların Sayısını Artırarak Kendi Bilgi Yarışması Oyununuzu Oluşturabilirsiniz. <br />
Ayrıca 'easyQuestionManager.cs' 390.Satırda Yer Alan number=Random.Range(0,5) ifadesindeki 5'i Yazmış Olduğunuz Soru Adeti İle Değiştirin. <br />
Soru Sayınız Ne Kadar Fazla İse Aynı Soruların Kullanıcıya Gözükme İhtimali O Kadar Azalır.
<br />
Örnek Olarak Soru Eklemek İstersek;<br />
else if (number == 4)<br />
        {<br />
            TxtQuestion.text = "Soru : Bakü Hangi Devletin Başkentidir ?";<br />
            TxtAnswer1.text = "Türkmenistan";<br />
            TxtAnswer2.text = "Gürcistan";<br />
            TxtAnswer3.text = "Kırgızistan";<br />
            TxtAnswer4.text = "Azerbaycan";<br />
            trueAnswer = "Azerbaycan";<br />
        }<br />
###### Not : 
Buradaki True Answer İçindeki Yazı İle Doğru Şıkkınızda Bulunan Yazının Bire Bir Aynı Olmasına Dikkat Ediniz...
