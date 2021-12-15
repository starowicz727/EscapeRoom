using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject movingWall;
    
    private void OnTriggerEnter(Collider other){
        if(other.tag == "vhsPlayer" && tag == "vhs"){
            StartAnim();
        }        
    }

    private void OnTriggerStay(Collider other){
        //wiecej sekund
        if(other.tag == "books" && tag == "book"){
            StartAnim();
        }
    }

    private void StartAnim(){
        Animator anim = movingWall.GetComponent<Animator>(); 
        anim.SetTrigger("startAnim");
    }
}
