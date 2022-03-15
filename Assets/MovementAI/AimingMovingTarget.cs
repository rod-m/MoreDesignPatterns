using MathHelpers;
using UnityEngine;

namespace MovementAI
{
    public class AimingMovingTarget : MonoBehaviour, IAimingMovingTarget
    {
        private Rigidbody target_rb;
        public GameObject target;
        private float _bulletVelocity= 5f;
    
        private void Start()
        {
            target_rb = target.GetComponent<Rigidbody>();
        }

        public Vector3 AimLoc()
        {
            Vector3 aimLoc = Targeting.GetMovingTarget(transform.position, _bulletVelocity, target.transform.position,
                target_rb.velocity);
            return aimLoc;
        }

        public void SetVelocity(float v)
        {
            _bulletVelocity = v;
        }
    }
}