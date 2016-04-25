using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour {

    Text[] textFields;
    Text scoreText, timeText;
    LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        textFields = GetComponentsInChildren<Text>();
        foreach(Text text in textFields)
        {
            if(text.name == "Score")
            {
                scoreText = text;
            }
        }
        levelManager = FindObjectOfType<LevelManager>();
        scoreText.text = "You've scored " + ScoreKeeper.MainScore.currentScore() + " points!";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
