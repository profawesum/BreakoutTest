using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //how fast the ball moves
    public float ballMoveSpeed;

    [SerializeField] UIManager uiManager;

    //finds out where the ball hit
    float hitFactor(Vector3 ballPosition, Vector3 playerPosition, float playerWidth){
        //returns where the ball hit
        return (ballPosition.x - playerPosition.x) / playerWidth;

    }
        //checks to see what the ball collides with
        private void OnCollisionEnter(Collision collision)
    {
        //if player
        if (collision.gameObject.tag == "Player") {
            //find where the ball hit
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            //calculate the direction of the ball
            Vector3 direction = new Vector3(x, 1, 0).normalized;

            //set the velocity of the ball
            GetComponent<Rigidbody>().velocity = direction * ballMoveSpeed * Time.deltaTime;
        }

        //if brick
        if (collision.gameObject.tag == "Brick") {
            //destroy the brick
            Destroy(collision.gameObject);
            //increase the score
            uiManager.increaseScore(100);
        }

        //if killzone
        if (collision.gameObject.tag == "KillZone") {
            //WILL NEED TO BE CHANGED
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
