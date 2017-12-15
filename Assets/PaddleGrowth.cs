using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGrowth : MonoBehaviour {


    Rigidbody rb;
    public float speed;
    public GameObject extraPaddle;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Paddle")
        {
            var spawn = Instantiate(extraPaddle);
            spawn.transform.position = other.transform.position + new Vector3(other.transform.localScale.x,0,0);
            spawn.transform.parent = other.transform;

            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        rb.velocity = Vector3.down * speed;
    }
}
