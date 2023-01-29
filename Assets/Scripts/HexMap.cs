using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour
{
    public GameObject hexPrefab; // Drag the hex prefab here in the inspector
    public int gridWidth = 10;
    public int gridHeight = 10;
    public float hexWidth = 1;
    public float hexHeight = 1;

    void Start()
    {
        // Calculate the starting position for the grid
        float startX = -((gridWidth / 2) * hexWidth);
        float startY = (gridHeight / 2) * hexHeight;

        // Loop through the grid and create hexes
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // Create a new hex
                GameObject hex = Instantiate(hexPrefab);
                hex.transform.parent = transform;

                hex.transform.position = new Vector3(startX + x * hexWidth * 0.75f, 0, startY - y * hexHeight * 0.5f);

                // Give the hex a name
                hex.name = "Hex_" + x + "_" + y;
            }
        }
    }
}



