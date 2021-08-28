using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //used for the speed to move the player paddle
    public float moveSpeed;

    [SerializeField] BallController ballController;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            ballController.launchBall();
            this.transform.DetachChildren();
        }

        //gets the move direction
        float moveDir = moveSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //moves the player paddle
        transform.Translate(moveDir, 0 , 0);
    }

}
