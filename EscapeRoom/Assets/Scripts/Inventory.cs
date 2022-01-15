using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled;
    public GameObject inventory;
    public GameObject infoText;

    public Transform slot1;
    public Transform slot2;
    public Transform slot3;

    bool closed = false;


    private void Start()
    {
        slot1 = slot1.transform.GetChild(0);
        slot2 = slot2.transform.GetChild(0);
        slot3 = slot3.transform.GetChild(0);
        ShowFoundItemsOnStart();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
        }

        if(inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        //Debug.Log("Trigger");
        RaycastHit rayHit;
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out rayHit))
            {
                if (other.gameObject.CompareTag("Item"))
                {
                    GameObject easterEgg = other.gameObject;

                    easterEgg.SetActive(false);
                    UpdateSlot(easterEgg);

                }
            }
        }
    }

    private void UpdateSlot(GameObject easterEgg)
    {
        if (easterEgg.name.Equals("Broom"))
        {
            slot1.GetComponent<RawImage>().enabled = true;
            GameState.Item1Found = true;
            ShowText();
        }
        else if (easterEgg.name.Equals("zdjecieBabci"))
        {
            slot2.GetComponent<RawImage>().enabled = true;
            GameState.Item2Found = true;
            ShowText();
        }
        else if (easterEgg.name.Equals("znajdzka"))
        {
            slot3.GetComponent<RawImage>().enabled = true;
            GameState.Item3Found = true;
            ShowText();
        }
    }

    private void ShowFoundItemsOnStart()
    {
        if(GameState.Item1Found == true)
        {
            slot1.GetComponent<RawImage>().enabled = true;
        }
        if(GameState.Item2Found == true)
        {
            slot2.GetComponent<RawImage>().enabled = true;
        }
        if(GameState.Item3Found == true)
        {
            slot3.GetComponent<RawImage>().enabled = true;
        }
    }
    private void ShowText()
    {
        if (inventoryEnabled == false)
        {
            inventoryEnabled = true;
            closed = true;
        }
        infoText.SetActive(true);
        StartCoroutine(HideText());
    }

    IEnumerator HideText()
    {
        yield return new WaitForSeconds(3);
        infoText.SetActive(false);
        if(closed == true)
        {
            yield return new WaitForSeconds(0);
            inventoryEnabled = false;
        }
        
    }




}
