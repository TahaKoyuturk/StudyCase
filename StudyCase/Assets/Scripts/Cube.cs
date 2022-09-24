using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.isKinematic = true;
            transform.SetParent(collision.transform);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenArea")
        {
            transform.parent = null;
        }
    }
}
