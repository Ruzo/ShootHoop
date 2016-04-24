using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour {

    int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if(score > 10)
        {
            SceneManager.LoadScene("GameOver");
        }
	}

    public void IncrementScore(int increment)
    {
        score += increment;
    }

    public int currentScore()
    {
        return score;
    }
}
