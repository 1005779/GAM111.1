using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float moveSpeed = 30.0f;
    public float lifeTime = 3.0f;
    public float damage = 100.0f;

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Life();
	
	}

    public void Move()
    {
        transform.position = transform.position + Vector3.forward * moveSpeed * Time.deltaTime; 
    }

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
