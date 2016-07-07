using UnityEngine;
using System.Collections;

public class Projectile : ballistics {

    public float lifeTime = 30.0f;
    public float damage = 100.0f;

	// Use this for initialization
	void Start () {
       
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
			otherObject.GetComponent<Enemy> ().takeDamage (damage);
			Destroy (this.gameObject);
		}
	}
}
