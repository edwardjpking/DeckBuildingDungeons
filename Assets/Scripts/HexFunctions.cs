using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexFunctions : MonoBehaviour
{

    /// Unity uses an even-q hex grid with r = x = row, q = -y = col
    public int[,,] direction_differences = {{{1,1},{1,0},{0,-1},{-1,0},{-1,1},{0,1}},{{1,0},{1,-1},{0,-1},{-1,-1},{-1,0},{0,1}}};


    // Converts the grid co-ordinate from offset (default) to axial (useful)
    public Vector3Int offsetToAxial(Vector3Int hex) {
        int q = hex[1];
        int r = - hex[0] - (hex[1] + Mathf.Abs(hex[1]%2)) / 2;
        return new Vector3Int(q, r, -10);
    }

    // Converts the grid co-ordinate from axial (useful) to offset (default)
    public Vector3Int axialToOffset(Vector3Int hex) {
        int col = hex[1];
        int row = hex[0] - (hex[1] + Mathf.Abs(hex[1]%2)) / 2;
        return new Vector3Int(col, row, -10);
    }

    // Returns the distance between two hexes in offset co-ordinates
    public float offsetDistance(Vector3Int a, Vector3Int b) {
        Vector3Int ac = offsetToAxial(a);
        Vector3Int bc = offsetToAxial(b);
        return axialDistance(ac, bc);
    }

    // Returns the distance between two hexes in axial co-ordinates
    public float axialDistance(Vector3Int a, Vector3Int b) {
        int aq = a[0];
        int bq = b[0];
        int ar = a[1];
        int br = b[1];
        return (Mathf.Abs(aq - bq) + Mathf.Abs(aq + ar - bq - br)+ Mathf.Abs(ar - br)) / 2;
    }


    // Return the offset co-ord of the neighbouring hex in a given direction
    // public Vector3Int evenOffsetNeighbor(Vector3Int hex, int direction, int parity) {
    //     int[] diff = even_direction_differences[parity][direction];
    //     return new Vector3Int(hex[0] + diff[0], hex[1] + diff[1], -10);
    // }

    // // Return all hexes a given distance away
    // public List<Vector3Int> allHexesAtDistance(Vector3Int centre, int dist) {
    //     /// Add centre hex
    //     ///
    //     List<Vector3Int> hex_list = new List<Vector3Int>();
    //     return hex_list;
    // }
}
