using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float health = 50.0f;
    private int point = 1;

    GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + Vector3.forward * moveSpeed * Time.deltaTime; 
	
	}

    public void takeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // AddPoint link to game manager
            Destroy(this.gameObject);
        }
    }
}
