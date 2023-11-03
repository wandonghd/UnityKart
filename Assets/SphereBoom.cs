using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBoom : MonoBehaviour
{
  public GameObject pickupEffect;

  void OnTriggerEnter (Collider other)
  {
    if (other.CompareTag("Player"))
    {
        Pickup();
    }
  }

  void Pickup()
  {
    Instantiate(pickupEffect, transform.position, transform.rotation);
    
    // Apply effect to the player

    Destroy(gameObject);
  }
}