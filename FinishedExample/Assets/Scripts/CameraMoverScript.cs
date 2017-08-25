using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoverScript : MonoBehaviour {

    public GameObject playerGameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // First lets check that the playerGameObject has been assigned and exists - otherwise we cannot do what we need to in the next
        // few lines of code.
        if (playerGameObject)
        {
            // Get and store our camera position so we can change it
            Vector3 cameraPosition = this.transform.position;

            // Set the camera's X position to the players X position
            cameraPosition.x = playerGameObject.transform.position.x;

            // Reset the camera's position to the one we have edited.
            this.transform.position = cameraPosition;
        }
	}
}
