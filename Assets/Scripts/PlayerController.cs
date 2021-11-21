using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mirror{
    public class PlayerController : NetworkBehaviour
    {

        //used for the speed to move the player paddle
        public float moveSpeed;

        [SerializeField] BallController ballController;

        private void Start()
        {
            //gets the reference to the ball
            if (isLocalPlayer)
            {
              ballController = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallController>();
            }
        }

        void FixedUpdate()
        {

            if (isLocalPlayer)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    //launches the ball
                    ballController.launchBall();
                }

                //gets the move direction
                float moveDir = moveSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
                //moves the player paddle
                this.transform.Translate(moveDir, 0, 0);
            }
        }
    }
}
