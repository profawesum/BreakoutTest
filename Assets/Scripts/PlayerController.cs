using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //used for the speed to move the player paddle
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        //gets the move direction
        float moveDir = moveSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //moves the player paddle
        transform.Translate(moveDir, 0 , 0);
    }

}
