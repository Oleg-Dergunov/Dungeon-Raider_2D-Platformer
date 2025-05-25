using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPickup : Pickup
{
    [Header("Extra Jump Settings")]
    [Tooltip("How many Jumps to allow")]
    public int bonusJumps = 2;


    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController PlayerJump = collision.gameObject.GetComponent<PlayerController>();
            PlayerJump.ChangeAllowedJump(bonusJumps);
        }
        base.DoOnPickup(collision);
    }

}