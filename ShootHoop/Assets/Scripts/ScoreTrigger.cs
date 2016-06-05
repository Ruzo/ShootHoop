using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

    public int score = 1;
    AudioSource source;
    bool ballEntry = false;
    Collider currentBall;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        currentBall = collider;
        if(currentBall.transform.position.y > transform.position.y)
        {
            ballEntry = true;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if ((collider == currentBall) && (currentBall.transform.position.y < transform.position.y)) {
            ScoreKeeper.MainScore.IncrementScore(score);
            source.Play();
        };
    }
}
