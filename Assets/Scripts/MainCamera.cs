using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float angle = 45f;
    public HexMap map;
    void Start()
    {
        Camera.main.orthographic = false;
        transform.rotation = Quaternion.Euler(angle, angle, 0);

        float mapWidth = map.mapWidth;
        float mapHeight = map.mapHeight;

        Vector3 centerPos = new Vector3((mapWidth * map.tileXOffset) / 2, 0, (mapHeight * map.tileZOffset) / 2);

        transform.position = centerPos + new Vector3(0, 10, 0);
    }
}
