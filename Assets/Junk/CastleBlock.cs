using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBlock : MonoBehaviour {

    public float shrinkTime;
    bool shouldShrink;

    ScoreManager manager;

    void shrink()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, shrinkTime * Time.deltaTime);
    }

	// Use this for initialization
	void Start ()
    {
        manager = FindObjectOfType<ScoreManager>();
        shouldShrink = false;	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground") 
        {
            if(!shouldShrink)
            {
                manager.UpdateScore(20);
                shouldShrink = true;
            }
            
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
