using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            Health PlayerHealth = Collision.gameObject.GetComponent<Health>();
            PlayerHealth.ReceiveHealing(PlayerHealth.maximumHealth);
            Destroy(this.gameObject);
        }
    }
}
