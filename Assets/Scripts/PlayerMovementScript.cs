using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private HexFunctions hf;
    private GridController gc;
    [SerializeField] private Grid grid;

    // Start is called before the first frame update
    void Start()
    {
        hf = GameObject.FindGameObjectWithTag("Scripts").GetComponent<HexFunctions>();
        gc = GameObject.Find("Grid").GetComponent<GridController>();
    }

    // Update is called once per frame
    void Update()
    {
        // On click - highlight hexes that can be moved to
        if (Input.GetMouseButton(Constants.LEFTCLICK))
        {

        }
    }

    void moveToMouse() {
        Vector3Int mousePos = gc.GetGridMousePosition();
        float dist = hf.offsetDistance(mousePos, Vector3Int.zero);
        if (dist < Constants.outOfBounds) {
            transform.position = grid.CellToWorld(mousePos);
        }
    }
}
