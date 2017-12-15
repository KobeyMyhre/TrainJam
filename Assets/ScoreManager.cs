using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public  class ScoreManager : MonoBehaviour {

    TextMesh scoreText;
    public float effectSpeed;
    public int score;
    public bool updated = false;

    Vector3 grow;
    Vector3 start;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<TextMesh>();
        scoreText.text = score.ToString();
        start = transform.localScale;
        grow = transform.localScale + new Vector3(.4f,.4f,.4f);

    }
	

    public void UpdateScore(int scoreAdded)
    {
        score += scoreAdded;
        scoreText.text = score.ToString();
        if(updated == false)
        {
            updated = true;
        }
        
    }
    bool shrink = false;

    void growEffect()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, grow, effectSpeed * Time.deltaTime);
        if(transform.localScale.x >= grow.x - 0.3f)
        {
            transform.localScale = start;
            updated = false;
        }
        
    }

	// Update is called once per frame
	void Update ()
    {
		if(updated)
        {
            growEffect();
        }
	}
}
