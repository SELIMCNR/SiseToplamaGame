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
            bitisYazisi.text = "OYUN BÝTTÝ \n TEKRAR OYNAMAK ÝÇÝN \n BÝR TUÞA BASIN";
            Time.timeScale = 0; //oyun hýzýný 0 yap durdur.

            if (Input.anyKeyDown) //HERHANGÝ BÝR TUÞA BASINCA ÞUNU YAP
            {
                //Yeniden baþlat sahneyi
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1; //oyunun hýzýný 1 yap 
            }
        }
    }
    //Temas iþlemleri
    void OnCollisionEnter2D(Collision2D temas)
    {
     

        //Rastgele þiþe oluþtur
        float rastgele = Random.Range(-8f, 8f);
        if (temas.gameObject.tag == "sise")
        {
            sise2.position = new Vector3(rastgele, 8f, 0f);
        }
        //zemine deðer ise þiþe yeniden oluþsun
        if (temas.gameObject.tag == "zemin")
        {
            sise2.position = new Vector3(rastgele, 8f, 0f);
            can--;//zemine deðer ise þiþe caný azalt
            siseDusurme.Play();
        }
    }
}
