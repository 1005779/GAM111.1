using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Component Declerations
    public GameObject turret;
    public GameObject barrel;
    public GameObject shell;
    public GameObject muzzel;

    //Variables for Controles
    public float tRotateSpeed = 10.0f;
    public float bRotateSpeed = 5.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Controle();
        Fire();

	}

    // Basic Controlles for the tank
    public void Controle()
    {
        // Barrel elevation controlles
        if (Input.GetKey("s"))
        {
            barrel.transform.Rotate(Vector3.right * -bRotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("w")) 
        { 
            barrel.transform.Rotate(Vector3.right * bRotateSpeed * Time.deltaTime);
        }
        
        // Turret Rotation controlles
        if (Input.GetKey("a"))
        {
            turret.transform.Rotate(Vector3.forward * -tRotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            turret.transform.Rotate(Vector3.forward * tRotateSpeed * Time.deltaTime);
        }
    }

    // Function For when you fire
    public void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shell, muzzel.transform.position, muzzel.transform.rotation);
            //also make barrel effects
            print("pew");
        }
    }

    
}
