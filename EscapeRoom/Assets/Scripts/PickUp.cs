using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour //skrypt przypisany do kamery gracza
{
    public float pickUpRange = 5;
    public float moveForce = 250;
    public Transform holdParent;

    private Transform heldObj;

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
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
        }

        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) //Podniesienie obiektu po naciœniêciu przycisku. Jeœli gracz trzyma jakiœ obiekt to wypuszczenie go
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    GameObject item = hit.transform.gameObject;
                    if (item.tag == "Item")
                    {
                        UpdateSlot(item);
                    }
                    else
                    {
                        PickupObject(item);
                    }
                    
                }
            }
            else
            {
                DropObject();
            }
        }

        if (heldObj != null)
        {
            MoveObject();
        }
    }

    void MoveObject() //poruszanie trzymanym obiektem
    {
        if (Vector3.Distance(heldObj.transform.position, holdParent.position) > 0.1f)
        {
            Vector3 moveDirection = (holdParent.position - heldObj.transform.position);
            heldObj.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);
        }
    }

    void PickupObject(GameObject pickObj) //Podnoszenie obiektu
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            Rigidbody objRig = pickObj.GetComponent<Rigidbody>();
            objRig.useGravity = false;
            objRig.drag = 10;

            objRig.transform.parent = holdParent;
            heldObj = pickObj.transform;
        }
    }

    void DropObject() //Puszczanie obiektu
    {
        Rigidbody heldRig = heldObj.GetComponent<Rigidbody>();
        heldRig.useGravity = true;
        heldRig.drag = 1;

        heldObj.transform.parent = null;
        heldObj = null;
    }

    public void UpdateSlot(GameObject easterEgg) //wyœwietlenie odpowiedniego zdjêcia
    {
        easterEgg.SetActive(false);
        if (easterEgg.name.Equals("Broom"))
        {
            slot1.GetComponent<RawImage>().enabled = true;
            GameState.Item1Found = true;
            ShowText();
            GameState.SaveMyGameState();
        }
        else if (easterEgg.name.Equals("zdjecieBabci"))
        {
            slot2.GetComponent<RawImage>().enabled = true;
            GameState.Item2Found = true;
            ShowText();
            GameState.SaveMyGameState();
        }
        else if (easterEgg.name.Equals("znajdzka"))
        {
            slot3.GetComponent<RawImage>().enabled = true;
            GameState.Item3Found = true;
            ShowText();
            GameState.SaveMyGameState();
        }
    }


    private void ShowFoundItemsOnStart()
    {
        if (GameState.Item1Found == true)
        {
            slot1.GetComponent<RawImage>().enabled = true;
        }
        if (GameState.Item2Found == true)
        {
            slot2.GetComponent<RawImage>().enabled = true;
        }
        if (GameState.Item3Found == true)
        {
            slot3.GetComponent<RawImage>().enabled = true;
        }
    }

    //wyœwietlenie informacji o zebraniu znajdzki
    private void ShowText()
    {
        if (inventoryEnabled == false)
        {
            inventoryEnabled = true;
            closed = true;
        }
        infoText.SetActive(true);
        FindObjectOfType<AudioManager>().Play("prize");
        StartCoroutine(HideText());
    }

    //ukrycie schowka
    IEnumerator HideText()
    {
        yield return new WaitForSeconds(3);
        infoText.SetActive(false);
        if (closed == true)
        {
            yield return new WaitForSeconds(0);
            inventoryEnabled = false;
        }

    }
}
