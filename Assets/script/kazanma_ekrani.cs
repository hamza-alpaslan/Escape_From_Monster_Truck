using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class kazanma_ekrani : MonoBehaviour
{
    public GameObject kazanma_canvas;
    public int sure;
    public Text kazanma_text;
    public int coin;
    void Update()
    {

        kazanma_canvas.SetActive(false);
        sure=coin_spawner.sure;
        coin= coin_spawner.toplam_coin;
        if (sure ==-1 )
        {
            Time.timeScale = 0f;
            kazanma_canvas.SetActive(true);
            kazanma_text.text = "Toplam kazanılan coin:" + (coin-1);
            araba_kontrol.donusHizi = 0f;
            araba_kontrol.hiz = 0f;
            dusman.hareketHizi = 0f;
            dusman.donmeHizi = 0f;


        }
    }

}
