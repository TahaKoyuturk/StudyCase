using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float moveSpeed;
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed, rb.velocity.y, joystick.Vertical * moveSpeed);

    }
}
