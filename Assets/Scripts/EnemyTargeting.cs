using System;
using MathHelpers;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class EnemyTargeting : MonoBehaviour
    {
        public Transform bulllet;
        public Transform gunBarrel;
        public float bulletVelocity = 5f;
        public GameObject target;
 
       public float speedRotation = 9f;
        private int shootDelay = 90;
        private Rigidbody target_rb;
        private void Start()
        {
            target_rb = target.GetComponent<Rigidbody>();
        }
        private void Update()
        {

            Vector3 aimLoc = Targeting.GetMovingTarget(transform.position, bulletVelocity, target.transform.position,target_rb.velocity);
           
            Targeting.RotateToTarget(transform, aimLoc, speedRotation);
            if (Time.frameCount % shootDelay == 0)
            {
               Transform b = Instantiate(bulllet, gunBarrel.position, gunBarrel.rotation);
               Rigidbody brb = b.GetComponent<Rigidbody>();
               brb.AddForce(transform.forward * bulletVelocity, ForceMode.Impulse);
               Destroy(b.gameObject, 3f);
            }
            
        }

       
    }
}