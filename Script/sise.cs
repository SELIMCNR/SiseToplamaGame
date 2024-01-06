using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class sise : MonoBehaviour
{
    [SerializeField]
    public Transform sise2;
    public Text canYazisi,bitisYazisi;
    public static int can=5;
    public AudioSource siseDusurme;
    public GameObject panel;

    void Update()
    {
        canYazisi.text = "Can: " + can;
        if (can == 0)
        {
            int puan = kutu_hareketi.puan;
            
            bitisYazisi.text = puan.ToString();
            bitisYazisi.text = "Oyun bitti ! \n  Puan�n : " + puan.ToString(); ;

            Time.timeScale = 0; //oyun h�z�n� 0 yap durdur.
            panel.active = true;
        }
    }
    //Temas i�lemleri
    void OnCollisionEnter2D(Collision2D temas)
    {
     

        //Rastgele �i�e olu�tur
        float rastgele = Random.Range(-1.95f, 1.95f);
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
