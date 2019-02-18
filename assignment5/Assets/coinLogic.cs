using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinLogic : MonoBehaviour
{
    //score
    public Text score;
    public int coins;
    private int numCoins;
    public Animator doorMove;
    public GameObject door;
    public ParticleSystem burst;
    bool collect;

    void Start()
    {//initialize stuff
        doorMove = door.GetComponent<Animator>();
        collect = false;
        coins = 0;
        numCoins = 2;
        score.text = "Coins - " + coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {//coin collection
        if (other.tag == "coin")
        {
            coins += 1;
            Destroy(other.gameObject);
            score.text = "Coins - " + coins.ToString();
            collect = true;
        }
    }

    private void Update()
    {
        if (coins >= numCoins)
        {
            doorMove.SetTrigger("moving");// play jump anim
            //Destroy(door);
        }

        if (collect)
        {
            burst.Emit(10);
            collect = false;
        }
    }

}
