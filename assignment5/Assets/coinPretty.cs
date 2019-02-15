using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPretty : MonoBehaviour
{

    private float spinzy = 50f;

    public float hover;
    Vector3 coinHover;
    private float coinY;

    private void Start(){
        hover = .01f;
        coinY = this.gameObject.transform.position.y;
    }

    void Update(){
        //spin the coins
        transform.Rotate(Vector3.forward, spinzy * Time.deltaTime);

        //give them a little bounce
        coinHover = new Vector3(this.gameObject.transform.position.x, 
                                this.gameObject.transform.position.y + hover,
                                this.gameObject.transform.position.z);
        transform.position = coinHover;
        if (coinY - .3 > this.gameObject.transform.position.y 
         || coinY + .3 < this.gameObject.transform.position.y){
            hover = -hover;
        }

    }
}
