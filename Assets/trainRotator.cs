using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainRotator : MonoBehaviour {

    public float speed;
   
    //public GameObject Cannon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, speed, 0);
        //Cannon.transform.rotation = Quaternion.Euler(Cannon.transform.rotation.x - transform.rotation.x, Cannon.transform.rotation.x - transform.rotation.x, 0);
	}
}
