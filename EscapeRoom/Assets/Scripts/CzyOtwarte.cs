using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CzyOtwarte : MonoBehaviour
{
    private int[] result, correctCombination;
    public GameObject portal;    
    public int Scena;
    public GameObject door;
    // Start is called before the first frame update
    private void Start()
    {
        if (Scena == 1)
        {
            result = new int[] { 5, 5, 5, 5 };
            correctCombination = new int[] { 2, 4, 1, 0 };
        }
        else if (Scena == 2)
        {
            result = new int[] { 5, 5, 5};
            correctCombination = new int[] { 8, 6, 8};
        }
        Rotacja.Rotated += CheckResults;
    }
    private void CheckResults(string wheelName, int number)
    {
        if (Scena == 1)
        {
            switch (wheelName)
            {
                case "Wheel1":
                    result[0] = number;
                    break;
                case "Wheel2":
                    result[1] = number;
                    break;
                case "Wheel3":
                    result[2] = number;
                    break;
                case "Wheel4":
                    result[3] = number;
                    break;
            }
            if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2] && result[3] == correctCombination[3])
            {
                Debug.Log("Opened!");
                portal.SetActive(true);
                FindObjectOfType<AudioManager>().Play("portal1");
            }
        }
        if (Scena == 2)
        {
            switch (wheelName)
            {
                case "Wheel1":
                    result[0] = number;
                    break;
                case "Wheel2":
                    result[1] = number;
                    break;
                case "Wheel3":
                    result[2] = number;
                    break;
            }
            if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
            {
                Debug.Log("Opened!");
                portal.SetActive(true);
                door.SetActive(false);
                FindObjectOfType<AudioManager>().Play("portal1");
            }
        }
    }

    private void onDestroy()
    {
        Rotacja.Rotated -= CheckResults;
    }
}
