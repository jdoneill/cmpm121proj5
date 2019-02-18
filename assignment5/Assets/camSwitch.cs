using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{

    public Camera back;
    public Camera front;

    private void Start()
    {
        back.enabled = true;
        front.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (back.enabled)
            {
                front.enabled = true;
                back.enabled = false;
            }

            else if (front.enabled)
            {
                back.enabled = true;
                front.enabled = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            front.enabled = true;
            back.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            back.enabled = true;
            front.enabled = false;
        }
    }
}
