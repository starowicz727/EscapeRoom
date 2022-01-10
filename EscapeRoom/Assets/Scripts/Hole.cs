using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
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

    private void Start()
    {
        holeH = transform.GetChild(0);
        holeO = transform.GetChild(0);
        holeK = transform.GetChild(0);
        holeU = transform.GetChild(0);
        holeS = transform.GetChild(0);
        holeP = transform.GetChild(0);
        holeO2 = transform.GetChild(0);
        holeK2 = transform.GetChild(0);
        holeU2 = transform.GetChild(0);
        holeS2 = transform.GetChild(0);
    }
    public void UpdateHole(GameObject letter)
    {
        if (letter.name.Equals("h"))
        {
            holeH.GetComponent<RawImage>().enabled = true;
        }
        else if(letter.name.Equals("o"))
        {
            holeO.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("k"))
        {
            holeK.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("u"))
        {
            holeU.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("s"))
        {
            holeS.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("p"))
        {
            holeP.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("o2"))
        {
            holeO2.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("k2"))
        {
            holeK2.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("u2"))
        {
            holeU2.GetComponent<RawImage>().enabled = true;
        }
        else if (letter.name.Equals("s2"))
        {
            holeS2.GetComponent<RawImage>().enabled = true;
        }
    }
}
