using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel;

        vel = transform.right * Input.GetAxisRaw("Horizontal");
        vel += transform.forward * Input.GetAxisRaw("Vertical");

        rb.AddForce(vel * speed * Time.deltaTime);
       //rb.AddForce(Vector3.back * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.transform.tag == "Asteroids")  
       {
            GameManager.gm.playing = false;
            Destroy(gameObject);
       }
    }
}
