using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    public GameObject cloth;
    private void OnMouseDown()
    {
        Destroy(cloth);
    }
}
