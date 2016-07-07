using UnityEngine;
using System.Collections;

public class ballistics : MonoBehaviour {

    // I will add this to both the aiming projectile that has a 
    // tracer to show the trajectory of the shot and the one the player fires

    // Ballistic Variables?
    public float X;
    public float launchAngel;
    public float gravity = 9.807f;
    public float velocity = 2.0f;
    public GameObject Barrel;

	// Use this for initialization
	void Start () {
        //launchAngel for balistics exuation
        launchAngel = Barrel.transform.rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        
        // Keeps track of the x position off the progectile
        X = this.gameObject.transform.position.x;
	}

    //the balistics ark for the projectile
    public void Move()
    {
        // Equation pulled appart
        float part1 = X * Mathf.Tan(launchAngel);
        float part2 = gravity * Mathf.Pow(X, 2.0f);
        float part3 = 2.0f * (Mathf.Pow((velocity * Mathf.Cos(launchAngel)), 2.0f));

        // All segments added together

            // currently moves at 10 times light speed
            // so it is impossible to tell if it works propperly.
        transform.Translate(0, (part1 - (part2 / part3)), 0);
    }
}
