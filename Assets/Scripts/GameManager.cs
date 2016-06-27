using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(int point)
    {
        score = score + point;
        print(score);
    }
}
