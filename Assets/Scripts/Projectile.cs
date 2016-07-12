using UnityEngine;
using System.Collections;

public class Projectile : ballistics {

    public float lifeTime = 30.0f;

    // For OnTriggerEnter
    public float damage = 100.0f;
    public int point = 1;

    GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
       Life();  
	}

    // Timer for how long the bullet lasts
    void Life()
    {
        lifeTime = lifeTime - Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(this.gameObject);
    }
    
    public void OnTriggerEnter (Collider otherObject){
		if (otherObject.tag == "Enemy") {

            otherObject.GetComponent<Enemy>().takeDamage(damage);
            otherObject.GetComponent<GameManager>().AddScore(point);
			Destroy (this.gameObject);
		}
	}
}
