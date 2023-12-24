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

    const bool LOCKED = true;
    int boardSize = 4;
    private Vector3Int previousMousePos = new Vector3Int();
    private Color previousColor = Color.white;

    // Start is called before the first frame update
    void Start() {
        grid = gameObject.GetComponent<Grid>();
        hf = GameObject.FindGameObjectWithTag("Scripts").GetComponent<HexFunctions>();
        foreach (var pos in BoardMap.cellBounds.allPositionsWithin) {
            BoardMap.SetTileFlags(pos, TileFlags.None);
        }
    }

    // Update is called once per frame
    void Update() {

        // Mouse over -> highlight tile
        hoverHighlight();

        // Left mouse click
        if (Input.GetMouseButtonUp(0)) {

        }

        // Right mouse click
        if (Input.GetMouseButtonUp(1)) {
            unhighlightAllTiles();
        }
    }

    // Get the mouse position in offset grid coordinates
    public Vector3Int GetGridMousePosition() {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int mouseGridPos = grid.WorldToCell(mouseWorldPos);
        return new Vector3Int(mouseGridPos[0], mouseGridPos[1], 0);
    }

    // Hover highlighting
    private void hoverHighlight() {
        Vector3Int mousePos = GetGridMousePosition();
        if (!mousePos.Equals(previousMousePos)){
            
            // Revert old tile
            highlightTile(previousMousePos, previousColor);
            previousColor = Color.white;

            // Recolour new tile
            highlightTile(mousePos, Color.red);

            previousMousePos = mousePos;
        }
    }

    // Gets distance between two hexes that are selected individually
    private void getDistBetweenTiles() {
        Vector3Int mousePos = GetGridMousePosition();

        highlightTile(mousePos, Color.green, true);

        // If there is no tile selected
        if (!pos1.HasValue) {
            pos1 = new Nullable<Vector3Int>(mousePos);
        }

        // If there is a tile selected
        else {
            float dist = hf.offsetDistance(pos1.Value, mousePos);
            Debug.Log(dist);
            highlightTile(pos1.Value, Color.white);
            pos1 = null;
        }
    }

    // Function to be called when selecting a tile
    public void highlightTile(Vector3Int pos, Color color, bool lockColor = false) {
        BoardMap.SetColor(pos, color);
        if (lockColor) {
            BoardMap.AddTileFlags(pos, TileFlags.LockColor);
        }
    }

    // Removes all highlighting from tiles and resets color flags
    public void unhighlightAllTiles() {
        foreach (var pos in BoardMap.cellBounds.allPositionsWithin) {
            BoardMap.RemoveTileFlags(pos, TileFlags.LockColor);
            highlightTile(pos, Color.white);
        }
    }

    // Highlight and lock a tile
    public void selectTile() {
        Vector3Int mousePos = GetGridMousePosition();
        highlightTile(mousePos, Color.green, LOCKED);
    }
}