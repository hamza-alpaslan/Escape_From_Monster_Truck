using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject hakkinda;
    private void Start()
    {
        hakkinda.SetActive(false);
    }
    public void basla()
    {

        Time.timeScale = 1f;
        coin_spawner.sure = 60;
        coin_spawner.toplam_coin = -1;
        coin_spawner.detected_true();
        araba_kontrol.donusHizi = 100f;
        araba_kontrol.hiz = 10f;
        dusman.hareketHizi = 5f;
        dusman.donmeHizi = 5f;
        SceneManager.LoadScene(1);
    }
    public void hakkinda_manu()
    {
        menu.SetActive(false);
        hakkinda.SetActive(true);
        // Kameranýn þu anki konumunu al
        Vector3 kameraKonum = transform.position;

        // Yeni x ekseni deðerini 60 olarak ayarla
        kameraKonum.x = -100f;
        kameraKonum.y = -76f;

        // Kameranýn konumunu güncelle
        transform.position = kameraKonum;
    }
    public void cikis()
    {
        Application.Quit();
    }
    public void back()
    {
        menu.SetActive(true);
        hakkinda.SetActive(false);
        // Kameranýn þu anki konumunu al
        Vector3 kameraKonum = transform.position;

        // Yeni x ekseni deðerini 60 olarak ayarla
        kameraKonum.x = -65f;
        kameraKonum.y = -78f;

        // Kameranýn konumunu güncelle
        transform.position = kameraKonum;
    }
}
