using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Basketball : MonoBehaviour
{
    public Transform baseDeMainTransform;

    public float ballSpeed = 10f;

    private Rigidbody rigBBall;


    void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Shoot();
        }
    }


    void ComparingTag(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Shoot();
            rigBBall = other.GetComponent<Rigidbody>();
        }

    }

    void Shoot()
    {
        rigBBall.velocity = baseDeMainTransform.forward * ballSpeed;

    }

}
