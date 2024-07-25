using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class coin_spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public static bool coin_detected = true;
    public static int toplam_coin = 0;
    public Text uiText;
    public Text uiText_sure;
    private float zamanlayici;
    public static int sure = 60;
    void Start()
    {
        coin_detected = true; // Oyun baþladýðýnda coin spawn etmeyi baþlat
        toplam_coin = 0;
    }
    void Update()
    {
        zamanlayici += Time.deltaTime;
        
        if (coin_detected)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-22, 22), 1, Random.Range(-15, 15));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
            coin_detected = false;
            uiText.text = "toplam altýn: "+toplam_coin;
            toplam_coin++;
        }
        if (zamanlayici >= 1f) // Yazma aralýðýna ulaþýldýðýnda
        {
            uiText_sure.text = "kalan süre: " + sure;
            sure--;
            zamanlayici = 0f; // Zaman sayacýný sýfýrla
        }
    }
    public static void detected_true()
    {
        coin_detected = true;
    }

}
