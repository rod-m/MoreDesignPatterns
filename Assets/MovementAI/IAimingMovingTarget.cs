using UnityEngine;

namespace MovementAI
{
    internal interface IAimingMovingTarget
    {
        Vector3 AimLoc();
        void SetVelocity(float v);
    }
}