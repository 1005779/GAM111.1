using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score = 0;
    public Text scoreText;

    public float timer;
    public Text timerText;

    Enemy enemy;
    public GameObject[] enemies;
    public int enemyCount;
    public Text enemyText;

	// Use this for initialization
	void Start () {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Texts();
        enemyCount = enemies.Length;
        Win();
	}

    public void AddScore(int point)
    {
        score = score + point;
    }

    public void Texts()
    {
        timerText.text = "Time: " + timer;
        scoreText.text = "Score: " + score;
        enemyText.text = "Enemies: " + enemyCount;
    }

    public void Win()
    {
        if (timer >= 300.0f)
        {
            // Set the Prefs to pass to the Win/Lose scene
            PlayerPrefs.SetString("WinLose", "WIN");
            PlayerPrefs.SetFloat("Time", timer);
            PlayerPrefs.SetInt("Score", score);

            // Loads Next Scene
            Application.LoadLevel("Win/Lose");
        }
    }
}
