using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Component Declerations
    public GameObject turret;
    public GameObject barrel;
    public Rigidbody shell;
    public Rigidbody tracer;
    public Transform muzzel;
    public float force = 1000.0f;
    public float multiplier = 3.0f;
    private float clock;

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
        Tracer();
	}

    // Basic Controlles for the tank
    public void Controle()
    {
        // Barrel elevation controlles
        if (Input.GetKey("s"))        
            barrel.transform.Rotate(Vector3.right * -bRotateSpeed * Time.deltaTime);
        
        else if (Input.GetKey("w"))         
            barrel.transform.Rotate(Vector3.right * bRotateSpeed * Time.deltaTime);
                
        // Turret Rotation controlles
        if (Input.GetKey("a"))
            turret.transform.Rotate(Vector3.forward * -tRotateSpeed * Time.deltaTime);
        
        else if (Input.GetKey("d"))        
            turret.transform.Rotate(Vector3.forward * tRotateSpeed * Time.deltaTime);
        
    }

    // Function For when you fire
    public void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody shot = Instantiate(shell, muzzel.transform.position, muzzel.transform.rotation) as Rigidbody;
            shot.AddForce(muzzel.transform.forward * (force * multiplier));
            print("pew");
        }
    }

    public void Tracer()
    {
        clock += Time.deltaTime;

        if (clock >= 5.0f)
        {
            Rigidbody trace = Instantiate(tracer, muzzel.transform.position, muzzel.transform.rotation) as Rigidbody;
            trace.AddForce(muzzel.transform.forward * (force * multiplier));
        }
    }

    
}
