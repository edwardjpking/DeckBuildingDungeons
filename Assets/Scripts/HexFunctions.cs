using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexFunctions : MonoBehaviour
{


    /*
    Unity uses an offset even-q hex grid with:
    q = Y = row
    r = - X - ( Y + ( Y % 2 ) ) / 2 and X = - col
    */


    // Offset Direction Differences - even columns first, odd columns second
    // Used to work out the vector to add to travel around the grid
    public Vector3Int[,] oDD = {
        {
            new Vector3Int(-1, -1, Constants.z), // dl (direction) - 0 (index)
            new Vector3Int(-1, 0, Constants.z), // down - 1
            new Vector3Int(-1, 1, Constants.z), // dr - 2
            new Vector3Int(0, 1, Constants.z), // ur - 3
            new Vector3Int(1, 0, Constants.z), // up - 4
            new Vector3Int(0, -1, Constants.z) // ul - 5
        },
        {
            new Vector3Int(0, -1, Constants.z), // dl - 0
            new Vector3Int(-1, 0, Constants.z), // down - 1
            new Vector3Int(0, 1, Constants.z), // dr - 2
            new Vector3Int(1, 1, Constants.z), // ur - 3
            new Vector3Int(1, 0, Constants.z), // up - 4
            new Vector3Int(1, -1, Constants.z) // ul - 5
        }
    };

    // Converts the grid co-ordinate from offset (default) to axial (useful)
    public Vector2Int offsetToAxial(Vector3Int hex) {
        int q = hex[1];
        int r = - hex[0] - (hex[1] + Mathf.Abs(hex[1]%2)) / 2;
        return new Vector2Int(q, r);
    }

    // Converts the grid co-ordinate from axial (useful) to offset (default)
    public Vector3Int axialToOffset(Vector2Int hex) {
        int col = hex[1];
        int row = hex[0] - (hex[1] + Mathf.Abs(hex[1]%2)) / 2;
        return new Vector3Int(col, row, Constants.z);
    }

    // Returns the distance between two hexes in offset co-ordinates
    public float offsetDistance(Vector3Int a, Vector3Int b) {
        Vector2Int ac = offsetToAxial(a);
        Vector2Int bc = offsetToAxial(b);
        return axialDistance(ac, bc);
    }

    // Returns the distance between two hexes in axial co-ordinates
    public float axialDistance(Vector2Int a, Vector2Int b) {
        int aq = a[0];
        int bq = b[0];
        int ar = a[1];
        int br = b[1];
        return (Mathf.Abs(aq - bq) + Mathf.Abs(aq + ar - bq - br)+ Mathf.Abs(ar - br)) / 2;
    }





    // Return all hexes a given distance away
    public List<Vector3Int> allHexesAtDistance(Vector3Int centreHex, int dist) {
        List<Vector3Int> hex_list = new List<Vector3Int>();
        Vector3Int currentHex = centreHex;
        int parity = Mathf.Abs(currentHex[1]%2);
        
        // Add centre hex
        hex_list.Add(currentHex);

        // Spiral covering
        for (int layerIdx = 1; layerIdx<dist+1; ++layerIdx) {
            
            // Add hex above stop point
            currentHex += oDD[parity, 3];
            if (offsetDistance(currentHex, Constants.origin) < 4) {
                hex_list.Add(currentHex);
            }

            // Return to top if necessary
            for (int layerWidthIdx = 0; layerWidthIdx < layerIdx - 1; ++layerWidthIdx) {
                currentHex += oDD[parity, 5];
                if (offsetDistance(currentHex, Vector3Int.zero) < 4) {
                    hex_list.Add(currentHex);
                }
            }

            // Add hexes in spiral
            for (int layerWidthIdx = 0; layerWidthIdx < layerIdx; ++layerWidthIdx) {    
                for (int dir = 0; dir < 5; ++dir) {
                    currentHex += oDD[parity, dir];
                    if (offsetDistance(currentHex, Vector3Int.zero) < 4) {
                        hex_list.Add(currentHex);
                    }
                }
            }
        }


        return hex_list;
    }
}
