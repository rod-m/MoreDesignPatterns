using UnityEngine;

internal interface IAimingMovingTarget
{
    Vector3 AimLoc();
    void SetVelocity(float v);
}