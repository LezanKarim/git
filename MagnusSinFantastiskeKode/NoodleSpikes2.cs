using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleSpikes2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    Vector3 oldPosition;

    private bool rotating = true;

    Quaternion startRotation;
    Quaternion endRotation;
    float rotationProgress = -1;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        StartRotating();
    }

    // Call this to start the rotation
    void StartRotating()
    {

        // Here we cache the starting and target rotations
        startRotation = transform.localRotation;
        endRotation = Quaternion.Euler(-100 - speed/2, -120, 0);

        // This starts the rotation, but you can use a boolean flag if it's clearer for you
        rotationProgress = 0;
    }

    void Update()
    {
        if (rotationProgress < 1 && rotationProgress >= 0)
        {
            rotationProgress += Time.deltaTime * 5;

            // Here we assign the interpolated rotation to transform.rotation
            // It will range from startRotation (rotationProgress == 0) to endRotation (rotationProgress >= 1)
            transform.localRotation = Quaternion.Lerp(startRotation, endRotation, rotationProgress);
        }
        StartRotating();
    }

    void FixedUpdate()
    {
        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;

    }
}
