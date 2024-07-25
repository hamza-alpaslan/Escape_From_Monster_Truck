
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonlar : MonoBehaviour
{
    public void tekrar_oyna()
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
    public void ana_menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
