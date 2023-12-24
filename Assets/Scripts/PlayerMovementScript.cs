using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private Constants cnst;
    private HexFunctions hf;
    private GridController gc;
    [SerializeField] private GameObject player;
    [SerializeField] private Grid grid;

    // Start is called before the first frame update
    void Start()
    {
        cnst = GameObject.FindGameObjectWithTag("Scripts").GetComponent<Constants>();
        hf = GameObject.FindGameObjectWithTag("Scripts").GetComponent<HexFunctions>();
        gc = GameObject.Find("Grid").GetComponent<GridController>();
    }

    // Update is called once per frame
    void Update()
    {
        // On click - highlight hexes that can be moved to
        if (Input.GetMouseButtonUp(0)){
            moveToMouse();
        }
    }

    void moveToMouse() {
        Vector3Int mousePos = gc.GetGridMousePosition();
        float dist = hf.offsetDistance(mousePos, cnst.origin);
        if (dist < cnst.outOfBounds) {
            player.transform.position = grid.CellToWorld(mousePos);
        }
    }
}
