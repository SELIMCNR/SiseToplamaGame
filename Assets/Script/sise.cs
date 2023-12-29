using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sise : MonoBehaviour
{
    [SerializeField]
    public Transform sise2;
    public Text canYazisi,bitisYazisi;
    public int can;
    public AudioSource siseDusurme;
    void Update()
    {
        canYazisi.text = "Can: " + can;
        if (can == 0)
        {
            bitisYazisi.text = "OYUN B�TT� \n TEKRAR OYNAMAK ���N \n B�R TU�A BASIN";
            Time.timeScale = 0; //oyun h�z�n� 0 yap durdur.

            if (Input.anyKeyDown) //HERHANG� B�R TU�A BASINCA �UNU YAP
            {
                //Yeniden ba�lat sahneyi
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1; //oyunun h�z�n� 1 yap 
            }
        }
    }
    //Temas i�lemleri
    void OnCollisionEnter2D(Collision2D temas)
    {
     

        //Rastgele �i�e olu�tur
        float rastgele = Random.Range(-8f, 8f);
        if (temas.gameObject.tag == "sise")
        {
            sise2.position = new Vector3(rastgele, 8f, 0f);
        }
        //zemine de�er ise �i�e yeniden olu�sun
        if (temas.gameObject.tag == "zemin")
        {
            sise2.position = new Vector3(rastgele, 8f, 0f);
            can--;//zemine de�er ise �i�e can� azalt
            siseDusurme.Play();
        }
    }
}
