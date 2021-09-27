using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    Rigidbody rb;
    public float force = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * force, ForceMode.Impulse);
        Destroy(gameObject, 2.5f);
    }

    private void OnCollisionEnter(Collision c)
    {
        Destroy(gameObject);
    }
}
