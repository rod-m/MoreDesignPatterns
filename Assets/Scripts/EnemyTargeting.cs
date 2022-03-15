using MathHelpers;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    public Transform bulllet;
    public Transform gunBarrel;
    public float bulletVelocity = 5f;
   
    public float speedRotation = 9f;
    private int shootDelay = 90;
   

    private AimingMovingTarget _aimingMovingTarget;
 
    private void Update()
    {
        // A: get target prediction
        var aimLoc = _aimingMovingTarget.AimLoc();
        // B: Rotate transform to target
        Targeting.RotateToTarget(transform, aimLoc, speedRotation);
        // C: shoot a missile at target
        if (Time.frameCount % shootDelay == 0)
        {
            Transform b = Instantiate(bulllet, gunBarrel.position, gunBarrel.rotation);
            Rigidbody brb = b.GetComponent<Rigidbody>();
            brb.AddForce(transform.forward * bulletVelocity, ForceMode.Impulse);
            Destroy(b.gameObject, 3f);
        }
    }
}

internal class AimingMovingTarget : MonoBehaviour
{
    private Rigidbody target_rb;
    public GameObject target;
    public float bulletVelocity = 5f;
    private void Start()
    {
        target_rb = target.GetComponent<Rigidbody>();
    }

    public Vector3 AimLoc()
    {
        Vector3 aimLoc = Targeting.GetMovingTarget(transform.position, bulletVelocity, target.transform.position,
            target_rb.velocity);
        return aimLoc;
    }
}