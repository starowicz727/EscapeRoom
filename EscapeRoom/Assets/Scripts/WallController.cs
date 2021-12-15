using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.tag == "vhs"){
           Animator anim = other.GetComponentInChildren<Animator>();  
           anim.SetTrigger("vhs");
           //explosion.gameObject.SetActive(true);
           //collisionParticipant.SetActive(false);
        }
    }
}
