using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    //player movement vars
    public CharacterController player;
    float speed;//speed of player
    float jump = 6;//height to jump on space
    private Vector3 move;
    public Animator character;

    void Start()
    {//initialize stuff
        player = GetComponent<CharacterController>();
    //    speed = 7;
    }

    private void FixedUpdate()
    {

        float yVel = move.y;//store y velocity for jump/gravity

        if (player.isGrounded && !Input.GetKey(KeyCode.LeftShift))//walk on ground
        {
            speed = 4;
            character.SetBool("Grounded", true);
            character.SetFloat("MoveSpeed", Input.GetAxis("Vertical")/2);//set anim to walk

        }
        else if (player.isGrounded && Input.GetKey(KeyCode.LeftShift))//run on ground
        {
            speed = 7;
            character.SetBool("Grounded", true);
            character.SetFloat("MoveSpeed", Input.GetAxis("Vertical"));//set anim to run

        }
        else if (!player.isGrounded)//walk slow on ground
        {
            speed = 4;
            character.SetBool("Grounded", false);//play jump anims
        }




        move = (transform.forward * Input.GetAxis("Vertical")//) //tank controls for now
             //+ (transform.right * Input.GetAxis("Horizontal")
             );

        move = move.normalized * speed;// make it so you can't game the game
        move.y = yVel;// replace y velocity from earlier

        if (player.isGrounded && Input.GetKeyDown(KeyCode.Space))//press space to jump
        {
            move.y = jump;//hippity hop
            character.SetTrigger("Jump");
        }

        move.y = move.y + (Physics.gravity.y * Time.deltaTime);
        player.Move(move * Time.deltaTime);//move the player

    }
}
