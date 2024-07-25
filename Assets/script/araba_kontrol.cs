using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_kontrol : MonoBehaviour
{
    public static float hiz = 10f; // Araban�n h�z�
    public static float donusHizi = 100f; // Araban�n d�n�� h�z�

    private float horizontalInput; // Yatay giri� de�eri
    private float verticalInput;
    

    private void Update()
    {
        // Klavyeden yatay giri�i al
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        hiz = verticalInput * 10f;
        donusHizi = verticalInput * 100f;
        // Araban�n ileri do�ru hareketi
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);

        // Araban�n d�nme hareketi
        float donusMiktari = horizontalInput * donusHizi * Time.deltaTime;
        transform.Rotate(Vector3.up, donusMiktari);
    }
}
