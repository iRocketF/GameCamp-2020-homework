using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;

    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private float health = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float xForce = Input.GetAxis("Horizontal");
        float zForce = Input.GetAxis("Vertical");

        Vector3 forceVector = new Vector3(xForce * speed, 0, zForce * speed);

        rb.AddForce(forceVector);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            if (health == 0)
            {
                Time.timeScale = 0f;
                Die();
            }
        }
    }

    private void Die()
    {

        Destroy(gameObject);
        
    }

}
