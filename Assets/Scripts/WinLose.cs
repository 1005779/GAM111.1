using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {
    // Variables to use for texts
    public string WL;
    public float time;
    public int score;

    // Text for UI
    public Text WiLo;
    public Text Time;
    public Text Score;

	// Use this for initialization
	void Start () {
        Text();
        time = PlayerPrefs.GetFloat("Time");
        score = PlayerPrefs.GetInt("Score");
        WL = PlayerPrefs.GetString("WinLose");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Text()
    {
        WiLo.text = WL;
        Time.text = "Time: " + time;
        Score.text = "Score: " + score;
    }

}
