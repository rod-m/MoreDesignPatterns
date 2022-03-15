using MathHelpers;
using UnityEngine;

namespace MovementAI
{
    internal class RotateTargetTo : MonoBehaviour, IRotateTargetTo
    {
        public Transform target;
        public float speedRotation = 5f;
        public void RotateToTarget()
        {
            Targeting.RotateToTarget(transform, target.position, speedRotation);
        }
    }
}