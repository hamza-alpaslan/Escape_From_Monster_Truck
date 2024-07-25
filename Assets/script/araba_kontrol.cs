using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_kontrol : MonoBehaviour
{
    public static float hiz = 10f; // Arabanýn hýzý
    public static float donusHizi = 100f; // Arabanýn dönüþ hýzý

    private float horizontalInput; // Yatay giriþ deðeri
    private float verticalInput;
    

    private void Update()
    {
        // Klavyeden yatay giriþi al
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        hiz = verticalInput * 10f;
        donusHizi = verticalInput * 100f;
        // Arabanýn ileri doðru hareketi
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);

        // Arabanýn dönme hareketi
        float donusMiktari = horizontalInput * donusHizi * Time.deltaTime;
        transform.Rotate(Vector3.up, donusMiktari);
    }
}
