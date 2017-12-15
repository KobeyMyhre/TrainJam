using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {


    float xRot;
    float yRot;


    public GameObject Cannonball;
    public float shootForce;


    public float shootCD;
    private float timer;

	// Use this for initialization
	void Start ()
    {
        xRot = 0;
        yRot = 180;
        timer = shootCD;
	}
   

    void CannonController()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        xRot += x;
        yRot += y;
       
        xRot = Mathf.Clamp(xRot,  -90, 90);
        yRot = Mathf.Clamp(yRot, 90, 270);
       
        transform.rotation = Quaternion.Euler(xRot, yRot, transform.rotation.z);
    }


    void Shoot()
    {
        timer -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            var spawn = Instantiate(Cannonball,transform.position,transform.rotation);
            Rigidbody rb = spawn.GetComponent<Rigidbody>();
            rb.AddForce(spawn.transform.forward * shootForce, ForceMode.Impulse);
            timer = shootCD;
        }

    }

	// Update is called once per frame
	void Update ()
    {
        CannonController();
        Shoot();

    }
}
