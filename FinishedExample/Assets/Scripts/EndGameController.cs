using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour {

    public int numberOfPickups;
    public string nextLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(numberOfPickups == 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
	}

    public void OnPickupRecieved()
    {
        numberOfPickups--;
    }
}
