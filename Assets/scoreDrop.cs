using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDrop : MonoBehaviour {


    public int scoreWorth;
    TextMesh myText;
    public float speed;
    ScoreManager myScore;

	// Use this for initialization
	void Start ()
    {
        myScore = FindObjectOfType<ScoreManager>();
        myText = GetComponent<TextMesh>();
        myText.text = scoreWorth.ToString();
	}





    // Update is called once per frame
    void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, myScore.gameObject.transform.position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, myScore.gameObject.transform.position) < 1)
        {
            myScore.UpdateScore(scoreWorth);
            gameObject.SetActive(false);
        }
    }
}
