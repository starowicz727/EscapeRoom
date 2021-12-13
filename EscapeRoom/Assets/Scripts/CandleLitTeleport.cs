using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLitTeleport : MonoBehaviour //skrypt przypisany do niezapalonej œwieczki
{
    public GameObject candle;
    public GameObject fire;
    public GameObject fireLight;
    public GameObject portal;
    void Update()
    {
        RaycastHit rayHit;
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out rayHit))
            {
                if (rayHit.collider.gameObject.Equals(candle.gameObject))
                {
                    // Debug.Log("hit kot ");
                    fire.SetActive(true);
                    fireLight.SetActive(true);
                    portal.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("portal1");
                }
            }
        }
    }
}
