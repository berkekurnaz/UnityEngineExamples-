using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bilgi : MonoBehaviour 
{

    /*Ana Menü Butonu Tıklama Olayları...*/
    public void AnaMenuTiklama()
    {
        SceneManager.LoadScene("LvlMenu");
    }

	void Update () 
    {
        /*Cihazın Geri Tuşuna Basınca Gerçekleşecek Olay...*/
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LvlMenu");
        }
	}

}
