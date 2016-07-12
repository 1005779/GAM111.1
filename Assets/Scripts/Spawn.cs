using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    
    GameManager gameManager;

    // Varibles for the Spawner
    public GameObject Jeep;
    public float spawnInterval;
    public float spawnTimer;
    public float timer;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Interval();
        spawn();
	}

    public void Interval()
    {
        // Sets Timer
        timer += Time.deltaTime;

        // As timer goes up spawnInterval Goes Down
        spawnInterval = Mathf.Log(timer) / Mathf.Log(2);
        print(spawnInterval);
    }

    public void spawn()
    {
        spawnTimer += Time.deltaTime;
        if (spawnInterval < spawnTimer )
        {
            Instantiate(Jeep, transform.position, transform.rotation);
            spawnTimer = 0.0f;
        }
    }
        
}
