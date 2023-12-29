using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kutu_hareketi : MonoBehaviour
{
    [SerializeField]
    public float hiz;
    [SerializeField]
    public Transform sise;
    public Text puanYazi;
     int puan;
    public AudioSource siseAlma;

    // Update is called once per frame
    void Update()
    {
        puanYazi.text = "Skor : " + puan;
        //Fare tuþuna göre sola saða kutuyu hareket ettir.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz*Time.deltaTime,0f,0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz*Time.deltaTime,0f,0f);
        }
    }

    //Temas iþlemleri
        void OnCollisionEnter2D(Collision2D temas)
    {

        //Rastgele þiþe oluþtur
        float rastgele = Random.Range(-8f, 8f);
        if (temas.gameObject.tag == "sise")
        {
            sise.position = new Vector3(rastgele, 8f, 0f);
            puan += 5; //sise temas ederse kutuya puan artýr
            siseAlma.Play();
        }
     
    }
}
