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
            if (isLocalPlayer)
            {
                if (this.gameObject.name == "PlayerOne")
                {
                    ballController = GameObject.Find("p1Ball").GetComponent<BallController>();
                }
                else {
                    this.gameObject.name = "PlayerTwo";
                    ballController = GameObject.Find("p2Ball").GetComponent<BallController>();
                }
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
