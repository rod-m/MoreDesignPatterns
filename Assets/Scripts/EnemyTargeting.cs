using System;
using MovementAI;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    public Transform bulllet;
    public Transform gunBarrel;
    public float bulletVelocity = 5f;
    private int shootDelay = 90;
    private IAimingMovingTarget _aimingMovingTarget;
    private IRotateTargetTo _rotateTarget;

    private void Start()
    {
        _aimingMovingTarget = GetComponent<IAimingMovingTarget>();
        _aimingMovingTarget.SetVelocity(bulletVelocity);
        _rotateTarget = GetComponent<IRotateTargetTo>();
    }

    private void Update()
    {
        // A: get target prediction
        var aimLoc = _aimingMovingTarget.AimLoc();
        // B: Rotate transform to target
        _rotateTarget.RotateToTarget();
        // C: shoot a missile at target
        FireMissile();
    }

    private void FireMissile()
    {
        if (Time.frameCount % shootDelay == 0)
        {
            Transform b = Instantiate(bulllet, gunBarrel.position, gunBarrel.rotation);
            Rigidbody brb = b.GetComponent<Rigidbody>();
            brb.AddForce(transform.forward * bulletVelocity, ForceMode.Impulse);
            Destroy(b.gameObject, 3f);
        }
    }
}