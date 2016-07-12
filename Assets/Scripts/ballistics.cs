using UnityEngine;
using System.Collections;

public class ballistics : MonoBehaviour {

    // I will add this to both the aiming projectile that has a 
    // tracer to show the trajectory of the shot and the one the player fires

    // Ballistic Variables?
    public Rigidbody shell;
    public Transform muzzel;
    public float force = 1000.0f;

	// Use this for initialization
    void Start()
    {
        Move();   
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    //the balistics ark for the projectile
    public void Move()
    {
        shell.AddForce(muzzel.forward * force);
    }
}
