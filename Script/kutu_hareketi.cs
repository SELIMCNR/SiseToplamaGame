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
   public static int  puan;
    public AudioSource siseAlma;

    // Update is called once per frame
    void Update()
    {
        float minX = -1.91f;
        float maxX = 1.91f;
        puanYazi.text = "Skor : " + puan;
        //Fare tu�una g�re sola sa�a kutuyu hareket ettir.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz*Time.deltaTime,0f,0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz*Time.deltaTime,0f,0f);
        }


        // Karakteri s�n�rlara k�rp
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            transform.position.y,
           transform.position.z
        );
    }

    //Temas i�lemleri
        void OnCollisionEnter2D(Collision2D temas)
    {

        //Rastgele �i�e olu�tur
        float rastgele = Random.Range(-2.15f, 2.15f);
        if (temas.gameObject.tag == "sise")
        {
            sise.position = new Vector3(rastgele, 8f, 0f);
            puan += 5; //sise temas ederse kutuya puan art�r
            siseAlma.Play();
        }
     
    }
}
