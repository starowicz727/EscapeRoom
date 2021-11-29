using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool pickedUp;
    [HideInInspector]
    public bool equipped;

    public void Update()
    {
        if(equipped)
        {

        }
    }

    public void ItemUsage()
    {
        if(type == "Ball")
        {
            equipped = true;
        }
    }

}
