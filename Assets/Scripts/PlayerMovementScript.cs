using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    // [SerializeField] private GameObject player;
    [SerializeField] private Grid grid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On click - highlight hexes that can be moved to
        if (Input.GetMouseButton(0))
        {
            
        }
    }
}
