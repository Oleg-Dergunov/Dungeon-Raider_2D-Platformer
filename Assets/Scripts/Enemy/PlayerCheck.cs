using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class PlayerCheck : MonoBehaviour
{
    [Header("Settings")]

    [Tooltip("The collider to check with. (Defaults to the collider on this game object.)")]
    public Collider2D PlayerCheckCollider = null;

    private bool Check = false;

    // Start is called before the first frame update
    void Start()
    {
        // When this component starts up, ensure that the collider is not null, if possible
        GetCollider();
    }

    

    /// <summary>
    /// Description:
    /// Attempts to setup the collider to be used with ground checking,
    /// if one is not already set up.
    /// Input: 
    /// none
    /// Return: 
    /// void (no return)
    /// </summary>
    public void GetCollider()
    {
        if (PlayerCheckCollider == null)
        {
            PlayerCheckCollider = gameObject.GetComponent<Collider2D>();
        }
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            Check = true;
        }
    }

    private void OnTriggerExit2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            Check = false;
        }
    }

    public bool CheckPlayer()
    {
        // Ensure the collider is assigned
        if (PlayerCheckCollider == null)
        {
            GetCollider();
        }

        return Check;
    }
}
