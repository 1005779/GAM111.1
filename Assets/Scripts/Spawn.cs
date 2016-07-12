using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    
    GameManager gameManager;

    // Varibles for the Spawner
    public GameObject Jeep;
    public float spawnInterval;
    public float spawnTimer;
    public float timer;
    public float constant = 1.0f;


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
        spawnInterval = -timer + constant;
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
