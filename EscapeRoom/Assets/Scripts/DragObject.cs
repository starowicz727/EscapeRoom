using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset; //offset to roznica pomiedzy polozeniam obiektu i kursora, to jest jakby 3d wektor(?)
    private float mZCoord;
    void OnMouseDown()
    {
        //zeby wziac pozycje z ekranu
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset = gameobject world pos - mouse world pos
        //metoda pozwakajaca pobrac pozycje kursora w swiecie 3d
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        //jak naciska sie lewy klawisz z metody OnMouseDown()
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    
    //pozycja kursora przypisana do pozycji obiektu
    //offset to roznica pomiedzy polozeniam obiektu i kursora, to jest jakby 3d wektor(?)
    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
}


//https://www.youtube.com/watch?v=0yHBDZHLRbQ&ab_channel=Jayanam