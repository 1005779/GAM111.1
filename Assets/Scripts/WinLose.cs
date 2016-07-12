using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {
    // Variables to use for texts
    public string WL;
    public float time;
    public int score;

    // Text for UI
    public Text WinLose;
    public Text Time;
    public Text Score;

	// Use this for initialization
	void Start () {

        time = PlayerPrefs.GetFloat("Time");
        score = PlayerPrefs.GetInt("Score");
        WL = PlayerPrefs.GetString("WinLose");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Text()
    {

    }

}
