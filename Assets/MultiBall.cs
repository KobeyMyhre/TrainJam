using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBall : MonoBehaviour {


    public GameObject ball;
    Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Paddle")
        {
            var spawn = Instantiate(ball);
            spawn.transform.position = transform.position + (Vector3.up * 3);
            
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        rb.velocity = Vector3.down * speed;	
	}
}
