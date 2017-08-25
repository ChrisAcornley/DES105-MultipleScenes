using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacterController : MonoBehaviour {

    float maxSpeed = 10f;
    float score = 0f;
    bool facingRight = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");

        Animator animatorComponent = this.GetComponent<Animator>();
        animatorComponent.SetFloat("moveSpeed", Mathf.Abs(move));

        Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(move * maxSpeed, rigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0f, 700f));
        }

        if (move > 0f && !facingRight)
        {
            Flip();
        }
        else if (move < 0f && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Try and find the 'ScoreText' GameObject
        GameObject scoreTextObject = GameObject.Find("ScoreText");

        // Get the Text component from the GameObject
        Text scoreTextComponent = scoreTextObject.GetComponent<Text>();

        // Update our score variable
        score += 10f;

        // Set the text of the 'ScoreText' GameObject to display the score
        scoreTextComponent.text = "Score: " + score;

        // Now that we have updated out score and out ScoreText - we can delete the trigger
        Destroy(collider.gameObject);
    }

    // Lets comment this out so it doesnt do anything for the time being
    /*
        void OnTriggerExit2D(Collider2D collider)
        {
            print("I have stopped colliding with a trigger");
        }
    */

    // Lets comment this out so it doesnt do anything for the time being
    /*
        void OnTriggerStay2D(Collider2D collider)
        {
            print("I am colliding with a trigger");
        }
    */
}
