using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_Display : MonoBehaviour {

    Text[] textFields;
    Text scoreText, timeText;
    ScoreKeeper scoreKeeper;
    LevelManager levelManager;

	// Use this for initialization
	void Start () {
        textFields = GetComponentsInChildren<Text>();
        scoreText = textFields[0];
        timeText = textFields[1];
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE: " + scoreKeeper.currentScore();
        timeText.text = string.Format("TIME: {0:00}", levelManager.currentTime());
	}
}
