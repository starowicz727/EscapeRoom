using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatKeyReplacement : MonoBehaviour
{
    public GameObject key;
    public GameObject explosion;
    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("Trigger kot ");
        RaycastHit rayHit;
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out rayHit))
            {
                //if (rayHit.collider.gameObject.CompareTag("Cat"))
                //{
                //    Debug.Log("hit kot ");
                //}
                if (rayHit.collider.gameObject.Equals(this.gameObject))
                {
                   // Debug.Log("hit kot ");
                    explosion.SetActive(true);
                    key.SetActive(true);
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}
