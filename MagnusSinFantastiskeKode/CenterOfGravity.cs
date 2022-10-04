using UnityEngine;
using System.Collections;

public class CenterOfGravity : MonoBehaviour
{

    public GameObject planet;
    private Rigidbody rb;
    [Range(0, 5)]
    public float factor = 1;
    public ForceMode mode;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 g = (planet.transform.position - transform.position) * factor;
        rb.AddForce(g, mode);
    }
}