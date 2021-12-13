using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesDisappear : MonoBehaviour // skrypt przypisany do wardrobe area, który jest w clothes,
                                              // w którym s¹ ciuchy w panelu hierarchii) 
{
    private void Update()
    {
        // Debug.Log("Trigger kot ");
        RaycastHit rayHit;
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out rayHit))
            {
                if (rayHit.collider.gameObject.tag=="Clothes")
                {
                    Debug.Log("hit");
                }
                //if (rayHit.collider.gameObject.Equals(this.gameObject))
                //{
                //    // Debug.Log("hit kot ");
                //    explosion.SetActive(true);
                //    key.SetActive(true);
                //    this.gameObject.SetActive(false);
                //}
            }
        }
    }
}
