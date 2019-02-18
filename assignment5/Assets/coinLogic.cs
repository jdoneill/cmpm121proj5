using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinLogic : MonoBehaviour
{
    //score
    public Text score;
    public int coins;
    public Animator doorMove;
    public GameObject door;

    void Start()
    {//initialize stuff
        //door = GetComponent<Animator>();
        coins = 0;
        score.text = "Coins - " + coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {//coin collection
        if (other.tag == "coin")
        {
            coins += 1;
            Destroy(other.gameObject);
            score.text = "Coins - " + coins.ToString();
        }
    }

    private void Update()
    {
        if (coins >= 2)
        {
            //doorMove.SetTrigger("move");// play move anim for door
            Destroy(door);
        }
    }

}
