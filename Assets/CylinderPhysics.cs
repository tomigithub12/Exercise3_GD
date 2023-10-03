using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderPhysics : MonoBehaviour
{

    private bool isFalling = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && !isFalling)
        {
            rb.isKinematic = false; // Disable kinematic to allow falling
            isFalling = true;
        }
    }
}
