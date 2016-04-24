using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string nextScene;
    public float levelTimeLimit = 0.0f;
    float timeInSeconds;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if ((levelTimeLimit > 0.0f))
        {
            timeInSeconds = levelTimeLimit - Time.timeSinceLevelLoad;
            if (timeInSeconds <= 0) LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public float currentTime()
    {
        return timeInSeconds;
    }
}
