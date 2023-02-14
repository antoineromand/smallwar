using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 lastMousePosition;
    public float scrollSpeed = 1f;

    public HexMap map;

    void Update()
    {
        //MouseMovement();
        //Centre moi la caméra
    }


    private void MouseMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Translate(-delta.x * scrollSpeed, -delta.y * scrollSpeed, 0f);
            lastMousePosition = Input.mousePosition;
        }
    }

}
