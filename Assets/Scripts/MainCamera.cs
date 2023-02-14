using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float angle = 45f;
    public HexMap map;

    void Start()
    {
        transform.position = new Vector3(map.mapWidth * map.tileXOffset / 2f, 3.5f, -3f);
        transform.rotation = Quaternion.Euler(30, 45, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * map.tileZOffset, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * map.tileZOffset, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * map.tileXOffset, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * map.tileXOffset, Space.Self);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            if (scroll < 0f && transform.position.y < 15f)
            {
                transform.Translate(Vector3.forward * scroll * map.tileXOffset, Space.Self);
            }
            else if (scroll > 0f && transform.position.y > 3.5f)
            {
                transform.Translate(Vector3.forward * scroll * map.tileXOffset, Space.Self);
            }
        }
    }
}