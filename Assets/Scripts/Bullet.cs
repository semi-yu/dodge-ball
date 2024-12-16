using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody bulletRigidbody;
    float speed = 8;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.linearVelocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") 
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null) {
                playerController.Die();
            }
        }
    }
}
