using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider FrontRight;
    [SerializeField] WheelCollider FrontLeft;
    [SerializeField] WheelCollider BackRight;
    [SerializeField] WheelCollider BackLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 30f;

    private float currentAcceleration = 0f ;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate() {


        // Get forward/reverse acceleration from the vertical axis (W & S keys)
        currentAcceleration = acceleration * Input.GetAxis("Vertical");



        // If we're pressing space, give currentBreakForce a value.
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;

        // Apply acceleration to front wheels.
        FrontRight.motorTorque = currentAcceleration;
        FrontLeft.motorTorque = currentAcceleration;

        // Apply breaking force to all wheels
        FrontRight.brakeTorque = currentBreakForce;
        FrontLeft.brakeTorque = currentBreakForce;
        BackRight.brakeTorque = currentBreakForce;
        BackLeft.brakeTorque = currentBreakForce;

        // Take care of the steering.
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        FrontLeft.steerAngle = currentTurnAngle;
        FrontRight.steerAngle = currentTurnAngle;

        // Update wheel meshes.
        UpdateWheel(FrontLeft, frontLeftTransform);
        UpdateWheel(FrontRight, frontRightTransform);
        UpdateWheel(BackLeft, backLeftTransform);
        UpdateWheel(BackRight, backRightTransform);

    }

    void UpdateWheel(WheelCollider col, Transform trans) {

        // Get wheel collider state.
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        // Set wheel transform state.
        trans.position = position;
        trans.rotation = rotation;

    }



}
