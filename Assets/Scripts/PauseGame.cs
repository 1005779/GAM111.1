using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

    public GameObject canavs;
    public GameObject tank;
	
	// Update is called once per frame
	void Update () {
        Menue();

	}

    public void Menue()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (canavs.gameObject.activeInHierarchy == false)
            {
                canavs.gameObject.SetActive(true);
                Time.timeScale = 0;
                tank.GetComponent<Player>().enabled = false;
            }
                else
            {
                canavs.gameObject.SetActive(false);
                Time.timeScale = 1;
                tank.GetComponent<Player>().enabled = true;
            }
                
    }
}
