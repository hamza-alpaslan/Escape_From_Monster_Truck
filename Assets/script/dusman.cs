using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
public class dusman : MonoBehaviour
{
    public Transform hedefKarakter;
    public static  float hareketHizi = 5f;
    public static float donmeHizi = 5f;
    public GameObject kaybetme_ekrani;
    public Text kaybetme_yazisi;
    private void Start()
    {
        kaybetme_ekrani.SetActive(false);
    }
    private void Update()
    {
        // Düþmanýn hedefe doðru hareket etmesi için yön hesaplanýr.
        Vector3 hareketYonu = Vector3.forward;

        // Düþmanýn karakteri takip etmesi saðlanýr.
        transform.Translate(hareketYonu * hareketHizi * Time.deltaTime);

        // Düþmanýn yönü karaktere doðru çevrilir.
        Quaternion donusYonu = Quaternion.LookRotation(hedefKarakter.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, donusYonu, donmeHizi * Time.deltaTime/2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Eðer çarpýþan nesne "Player" tag'ine sahipse
        {
            Time.timeScale = 0f;
            kaybetme_ekrani.SetActive(true);
            kaybetme_yazisi.text = "Toplam kazanýlan coin:" + (coin_spawner.toplam_coin-1);
            araba_kontrol.donusHizi = 0f;
            araba_kontrol.hiz = 0f;
            dusman.hareketHizi = 0f;
            dusman.donmeHizi = 0f;
        }

    }
}
