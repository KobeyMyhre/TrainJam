using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horz = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position + new Vector3( + horz, 0, 0);
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
	}
}
