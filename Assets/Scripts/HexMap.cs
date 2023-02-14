using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour
{
    public GameObject hexPrefab;
    [SerializeField] public int mapWidth = 25;
    [SerializeField] public int mapHeight = 25;
    public float tileXOffset = 2.1f;
    public float tileZOffset = 1.9f;
    
    
    void Start()
    {
        createMap();
    }

    void createMap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int z = 0; z < mapHeight; z++)
            {
                GameObject hex = Instantiate(hexPrefab);

                if (z % 2 == 0)
                {
                    hex.transform.position = new Vector3(x * tileXOffset, 0, z * tileZOffset);
                }
                else
                {
                    hex.transform.position = new Vector3(x * tileXOffset + tileXOffset / 2, 0, z * tileZOffset);
                }
                SetTileInfo(hex, x, z);
            }
        }
    }
    
    void SetTileInfo(GameObject Go, int x, int z)
    {
        Go.transform.SetParent(transform);
        Go.name = x.ToString() + ", " + z.ToString();
    }
}

