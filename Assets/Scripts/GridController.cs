using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;


public class GridController : MonoBehaviour
{
    private Grid grid;
    private HexFunctions hf;
    public Nullable<Vector3Int> pos1 = null;
    [SerializeField] private Tilemap BoardMap = null;



    private Vector3Int previousMousePos = new Vector3Int();
    private Color previousColor = Color.white;

    // Start is called before the first frame update
    void Start() {
        grid = gameObject.GetComponent<Grid>();
        hf = GameObject.FindGameObjectWithTag("Scripts").GetComponent<HexFunctions>();
    }

    // Update is called once per frame
    void Update() {

        // Mouse over -> highlight tile
        hoverHighlight();

        // Left mouse click
        if (Input.GetMouseButtonUp(0)) {
            selectTile();
        }

        // Right mouse click
        if (Input.GetMouseButtonUp(1)) {
            // Debug.Log(GetGridMousePosition());
        }
    }


    // Get the mouse position in offset grid coordinates
    Vector3Int GetGridMousePosition() {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int mouseGridPos = grid.WorldToCell(mouseWorldPos);
        return new Vector3Int(mouseGridPos[0], mouseGridPos[1], 0);
    }


    // Hover highlighting
    void hoverHighlight() {
        Vector3Int mousePos = GetGridMousePosition();
        float distFromCentre = hf.offsetDistance(mousePos, new Vector3Int(0, 0, 0));
        if (!mousePos.Equals(previousMousePos) & distFromCentre < 4){

            // Revert old tile
            BoardMap.SetTileFlags(previousMousePos, TileFlags.None);
            BoardMap.SetColor(previousMousePos, previousColor);

            // Recolour new tile
            // previousColor = BoardMap.GetColor(mousePos);
            BoardMap.SetTileFlags(mousePos, TileFlags.None);
            BoardMap.SetColor(mousePos, Color.red);

            previousMousePos = mousePos;
        }
    }


    // Gets distance between two hexes that are selected individually
    void getDistBetweenTiles() {
        Vector3Int mousePos = GetGridMousePosition();

        BoardMap.SetTileFlags(mousePos, TileFlags.None);
        BoardMap.SetColor(mousePos, Color.green);
        // If there is no tile selected
        if (!pos1.HasValue) {
            pos1 = new Nullable<Vector3Int>(mousePos);
        }

        // If there is a tile selected
        else {
            float dist = hf.offsetDistance(pos1.Value, mousePos);
            Debug.Log(dist);
            BoardMap.SetTileFlags(pos1.Value, TileFlags.None);
            BoardMap.SetColor(pos1.Value, Color.white);
            pos1 = null;
        }
    }


    void selectTile() {
        Vector3Int mousePos = GetGridMousePosition();

        BoardMap.SetTileFlags(mousePos, TileFlags.None);
        BoardMap.SetColor(mousePos, Color.green);
    }
}