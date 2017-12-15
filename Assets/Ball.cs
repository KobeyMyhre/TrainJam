using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    [HideInInspector]
    public Rigidbody rb;
    public float speed;
    public bool isAlive = true;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        startVel();
	}
    public void startVel()
    {
        Vector2 startVel = Random.insideUnitCircle;
        startVel.y = Mathf.Abs(startVel.y);
        rb.velocity = startVel * speed;
    }
	

    void maintainVel()
    {
        float velX = rb.velocity.x;
        float velY = rb.velocity.y;

        if(Mathf.Abs(velX) < speed || Mathf.Abs(velY) < speed)
        {
            rb.velocity = new Vector2(speed * Mathf.Sign(velX), speed * Mathf.Sign(velY));
        }


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Paddle")
        {
            float xHand = Mathf.Sign(rb.velocity.x);

            Vector3 hitDir =  other.transform.position - transform.position;
            float collHand = Mathf.Sign(hitDir.x);

            if (xHand == collHand)
            {
                float newX = rb.velocity.x * -1;
                rb.velocity = new Vector3(newX, rb.velocity.y, rb.velocity.z);
            }
        }


    }

    // Update is called once per frame
    void Update ()
    {
        if(isAlive)
            maintainVel();
	}
}
