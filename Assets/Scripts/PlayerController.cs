using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked object is a hexagon
                HexTile hexTile = hit.transform.GetComponent<HexTile>();
                if (hexTile != null)
                {
                    // Change the hexagon color
                    Renderer renderer = hexTile.GetComponent<Renderer>();
                    renderer.material.color = Color.red;
                }
            }
        }
    }
}
