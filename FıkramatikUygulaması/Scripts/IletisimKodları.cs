using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class IletisimKodları : MonoBehaviour
{

    public InputField adsoyad;
    public InputField email;
    public InputField mesaj;

    public Text hata;


    void Start()
    {

    }

    public void sendmail_start()
    {
        StartCoroutine(sendmail());
    }

    public IEnumerator sendmail()
    {
        yield return new WaitForSeconds(0.0f);

        if (mesaj.text == "" || adsoyad.text == "" || email.text == "")
        {
            hata.text = "Hatali Yollama Sekli...";
        }
        else
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email.text);
            mail.To.Add("kurnaz.berke1907@gmail.com");
            mail.Subject = mesaj.text;
            mail.Body = "Gönderen Adres: " + email.text + "\n" + mesaj.text;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("BurayaEmailAdresiniYaz", "BurayadaSifresiniYaz") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate(object s,X509Certificate certificate,X509Chain chain,SslPolicyErrors sslPolicyErrors)
                {return true;};
            smtpServer.Send(mail);
            hata.text = "Basarılı Bir Sekilde Gonderildi...";
        }
    }

    void Update()
    {

    }
}
