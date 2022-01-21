using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LettersPick : MonoBehaviour
{
    public Transform holeH;
    public Transform holeO;
    public Transform holeK;
    public Transform holeU;
    public Transform holeS;
    public Transform holeP;
    public Transform holeO2;
    public Transform holeK2;
    public Transform holeU2;
    public Transform holeS2;
    public static int ileZebranych = 0;
    public GameObject portal;

    private void Start()
    {
        holeH = holeH.transform.GetChild(0);
        holeO = holeO.transform.GetChild(0);
        holeK = holeK.transform.GetChild(0);
        holeU = holeU.transform.GetChild(0);
        holeS = holeS.transform.GetChild(0);
        holeP = holeP.transform.GetChild(0);
        holeO2 = holeO2.transform.GetChild(0);
        holeK2 = holeK2.transform.GetChild(0);
        holeU2 = holeU2.transform.GetChild(0);
        holeS2 = holeS2.transform.GetChild(0);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");
        RaycastHit rayHit;
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mysz");
            if (Physics.Raycast(ray, out rayHit))
            {
                Debug.Log("ray");
                if (other.gameObject.CompareTag("letter"))
                {
                    GameObject letter = other.gameObject;

                    letter.SetActive(false);
                    UpdateHole(letter);
                    Debug.Log("dziala");
                }
            }
        }
    }

    private void UpdateHole(GameObject letter)
    {
        if (letter.name.Equals("h"))
        {
            Debug.Log(holeH.GetComponent<RawImage>());
            holeH.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("o"))
        {
            holeO.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("k"))
        {
            holeK.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("u"))
        {
            holeU.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("s"))
        {
            holeS.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("p"))
        {
            holeP.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("o2"))
        {
            holeO2.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("k2"))
        {
            holeK2.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("u2"))
        {
            holeU2.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }
        else if (letter.name.Equals("s2"))
        {
            holeS2.GetComponent<RawImage>().enabled = true;
            ileZebranych++;
        }


        if(ileZebranych == 10)
        {
            portal.SetActive(true);
        }
    }
}
