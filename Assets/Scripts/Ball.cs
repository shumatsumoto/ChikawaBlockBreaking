using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isDead = false;
    public float speed = 3.5f;
    public float accelSpeed = 2.1f;
    bool isStart = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == false && Input.GetMouseButtonDown(0))
        {
            isStart = true;
            rb.AddForce(new Vector3(1, -1, 0) * speed, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "wall_bottom")
        {
            isDead = true;
        }

        if (collision.gameObject.name == "Bar")
        {
            speed += accelSpeed;
            Vector3 vec = transform.position - collision.transform.position;
            rb.velocity = Vector3.zero;
            rb.AddForce(vec.normalized * speed, ForceMode.VelocityChange);
        }
    }
}
