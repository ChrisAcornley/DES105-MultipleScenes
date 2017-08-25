using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonController : MonoBehaviour {

    // We can initialse the Button to call the bottom function when clicked
    void Start()
    {
        // Get the Button component of the GameObject this script is attached to.
        Button exitButton = this.GetComponent<Button>();

        // Make sure that the exitButton object exists - this way we can attach the script to another 'non-button' GameObject and it will not
        // cause the game to crash.
        if(exitButton)
        {
            // Tell the Button to call the 'onExitButtonPressed' function when it is clicked.
            exitButton.onClick.AddListener(onExitButtonPressed);
        }
    }

    // Handles the Exit button in the UI Canvas being pressed.
	public void onExitButtonPressed()
    {
        // Print a message for the console window
        print("Hello, this is a console message.");
    }
}
