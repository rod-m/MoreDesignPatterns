using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
   public int damage = 10;
   private void OnCollisionEnter(Collision other)
   {
      if (other.collider.CompareTag("Player"))
      {
         other.gameObject.SendMessage("Damage", damage);
      }
      
      Destroy(gameObject);
   }
}
