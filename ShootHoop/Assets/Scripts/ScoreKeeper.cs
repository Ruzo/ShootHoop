using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncrementScore(int increment)
    {
        score += increment;
        print("Score: " + score);
    }
}
