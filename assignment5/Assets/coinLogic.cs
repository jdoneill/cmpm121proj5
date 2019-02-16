using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinLogic : MonoBehaviour
{
    //score
    public Text score;
    int coins;

    void Start()
    {//initialize stuff
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

}
