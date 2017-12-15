using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {


    public int hits;
    public bool shouldShrink;
    public float shrinkTime;
    public GameObject scoreDrop;
    public GameObject powerUp;
	// Use this for initialization
	void Start () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            hits--;
            if(hits <= 0)
            {
                GetComponent<BoxCollider>().enabled = false;
                var spawn = Instantiate(scoreDrop);
                spawn.transform.position = transform.position;
                shouldShrink = true;
                if(powerUp != null)
                {
                    var spawnPP = Instantiate(powerUp);
                    spawnPP.transform.position = transform.position;
                }
            }
        }
    }


    void shrink()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, shrinkTime * Time.deltaTime);
        if(transform.localScale == Vector3.zero)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update ()
    {
		if(shouldShrink)
        {
            shrink();
        }
	}
}
