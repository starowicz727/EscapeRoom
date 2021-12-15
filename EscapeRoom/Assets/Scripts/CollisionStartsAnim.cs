using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStartsAnim : MonoBehaviour  //skrypt przypisany do przedmiotu kt�ry nie znika ze sceny 
{                                                 //czyli np. odtwarzacz VHS, szafa
    public GameObject collisionParticipant;
    public ParticleSystem explosion;
    //public Animation resultingAnimation; //przypisana ta animacja 
    //obj = ten obj ktory chcemy animowac
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.Equals(collisionParticipant))
        {
            explosion.gameObject.SetActive(true);
            //trigger set active albo play anim
            //resultingAnimation.Play();
            collisionParticipant.SetActive(false);
        }
    }
}
