using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    public GameObject cloth;
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("Trigger");
    //    RaycastHit rayHit;
    //    var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (Physics.Raycast(ray, out rayHit))
    //        {


    //            Destroy(cloth);
    //        }
    //    }
    //}

    private void OnMouseDown()
    {
        Destroy(cloth);
    }
}
