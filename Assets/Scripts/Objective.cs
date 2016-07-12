using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour {

    GameManager gameManager;
    public float timer;
    public int score;

	// Use this for initialization
	void Start () {
        // Set where to get the values
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();       	
	}
	
	// Update is called once per frame
	void Update () {
        // Set the values to pass on
        timer = gameManager.timer;
        score = gameManager.score;	
	}

    public void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Enemy")
        {
            // Set the Prefs to pass to the Win/Lose scene
            PlayerPrefs.SetString("WinLose", "LOSE");
            PlayerPrefs.SetFloat("Time", timer);
            PlayerPrefs.SetInt("Score", score);
            
            // Loads Next Scene
            Application.LoadLevel("Win/Lose");
        }
    }
}
