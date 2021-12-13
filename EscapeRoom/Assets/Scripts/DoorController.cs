using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //public GameObject collisionParticipant;
    //public ParticleSystem explosion;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "keyhole"){
           Animator anim = other.GetComponentInParent<Animator>();  
           anim.SetTrigger("keyInserted");
           //explosion.gameObject.SetActive(true);
           //collisionParticipant.SetActive(false);
        }
    }
}
