using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class trainMoveTo : MonoBehaviour {


    NavMeshAgent agent;
    public Transform[] locs;
    public int currentIdx;
	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = locs[currentIdx].position;
	}
	
    void moveTo()
    {
        if(Vector3.Distance(transform.position,agent.destination) < 1)
        {
            currentIdx++;
            if(currentIdx >= locs.Length)
            {
                currentIdx = 0;
            }
            agent.destination = locs[currentIdx].position;

        }
    }


	// Update is called once per frame
	void Update ()
    {
        moveTo();
	}
}
