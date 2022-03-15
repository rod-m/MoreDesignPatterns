using UnityEngine;
namespace MathHelpers
{
    public static class Targeting
    {
        public static Vector3 GetMovingTarget(Vector3 source, float projectileSpeed, Vector3 destination,
            Vector3 destinationVelocity)
        {
            // inaccurate targeting ignores target direction
            float timeToDestinationNow = 0;
            float _speed = destinationVelocity.magnitude;
            if (_speed > 0.01f)
            {
                // target is moving
                timeToDestinationNow = Vector3.Distance(source, destination) / projectileSpeed;
                destination += destinationVelocity * timeToDestinationNow;

            }

            //Debug.Log($"timeToDestinationNow {timeToDestinationNow} _speed {_speed} destination {destinationVelocity.ToString()}");
            return destination;
        }

        public static void RotateToTarget(Transform _from, Vector3 aimTo, float speed)
        {
            // Determine which direction to rotate towards
            Vector3 targetDirection = aimTo - _from.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(_from.forward, targetDirection, singleStep, 0.0f);

            // Draw a ray pointing at our target in
            Debug.DrawRay(_from.position, newDirection * 10, Color.red);

            // Calculate a rotation a step closer to the target and applies rotation to this object
            _from.rotation = Quaternion.LookRotation(newDirection);
            //Debug.Log($"rotation {newDirection.magnitude}");
        }
    }
}