using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    private void Start()
    {
        allSlots = 20;
        slot = new GameObject[allSlots];

        for(int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
            
            if(slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
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

    private void OnTriggerStay(Collider other) //TUTAJ JESZCZE CHYBA SPRAWDZIÆ TRZEBA BÊDZIE TAG 
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
                    GameObject itemPickedUp = other.gameObject;
                    Item item = itemPickedUp.GetComponent<Item>();

                    AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
                }
            }
        }
    }

    void AddItem(GameObject itemObjects, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for(int i = 0; i < allSlots; i++)
        {
            if(slot[i].GetComponent<Slot>().empty)
            {
                itemObjects.GetComponent<Item>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemObjects;
                slot[i].GetComponent<Slot>().icon = itemIcon;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().description = itemDescription;

                itemObjects.transform.parent = slot[i].transform;
                itemObjects.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;
            }
            return;
        }
    }

    

}
