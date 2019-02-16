using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{

    public Camera back;
    public Camera front;

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
    }
}
