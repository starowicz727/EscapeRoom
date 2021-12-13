using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStartsAnim : MonoBehaviour
{
    public GameObject collisionParticipant;
    public ParticleSystem explosion;
    public Animation resultingAnimation;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.Equals(collisionParticipant))
        {
            explosion.gameObject.SetActive(true);
            resultingAnimation.Play();
            collisionParticipant.SetActive(false);
        }
    }
}
