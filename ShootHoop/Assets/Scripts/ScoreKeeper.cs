using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour {

    public static ScoreKeeper MainScore;

    int score = 0;

    void Awake ()
    {
        DontDestroyOnLoad(gameObject);

        if(MainScore == null)
        {
            MainScore = this;
        }
        else if(MainScore != this)
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	}

    public void IncrementScore(int increment)
    {
        score += increment;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public int currentScore()
    {
        return score;
    }
}
