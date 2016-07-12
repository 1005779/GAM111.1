using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    // Damage and scoring Variables
    public float health = 50.0f;
       
    GameManager gameManager;

    // Variables for the Movement function
    public GameObject objective;
    private float rotateSpeed = 2.0f;
    private float adjRotSpeed;
    private Quaternion targetRotation;
    public float moveSpeed = 10.0f;



	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	
	}

    public void takeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void Movement()
    {
        // This tells the enemy to look at the Objective
            //for some strange reason they ony for to the position the block was at when i made it a prefab and not its current position
            targetRotation = Quaternion.LookRotation(objective.transform.position - transform.position);
            adjRotSpeed = Mathf.Min(rotateSpeed * Time.deltaTime, 1);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, adjRotSpeed);
        

        // This tells the enemy to move to the "front"
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    
}
