using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // E�er �arp��an nesne "Player" tag'ine sahipse
        {
            coin_spawner.coin_detected = true;
            Destroy(gameObject); // Coin'i yok et
        }
        
    }
}
