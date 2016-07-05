using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float moveSpeed = 30.0f;
    public float lifeTime = 30.0f;
    public float damage = 100.0f;

    // Ballistic Variables?

    public float X;
    public float Y;
    public float launchAngel;
    public float gavity;
    public Vector3 currentVector;
    public Vector3 LaunchAngel;
    public GameObject Barrel;

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        
        Move();
        Life();
	
	}

    public void BalisticVariables()
    {
        X = this.gameObject.transform.position.x;
        Y = this.gameObject.transform.position.Y;
        //launchAngel

    }

    public void Move()
    {
        
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
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
