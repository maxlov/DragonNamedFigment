using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectileLogic : MonoBehaviour
{
    private float velocity = 10f;
    private float damage = 1f;
    
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void ProjectileSetup(float inputVelocity, float inputDamage)
    {
        velocity = inputVelocity;
        damage = inputDamage;
    }

    private void Update()
    {
        rb.velocity += Time.deltaTime * velocity * transform.forward;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " dealt " + damage + " to " + collision.gameObject.name);
        Destroy(gameObject);
    }
}
