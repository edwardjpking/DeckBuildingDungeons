using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {

    public class PlayerClass : MonoBehaviour
    {
        public class Player
        {

            // Define variables
            private int Hitpoints { get; set; }
            private int BaseActions { get; set; }
            private int RemainingActions { get; set; }
            private int DefaultMovement { get; set; }
            private int TeamNumber { get; set; }
            private int Burn { get; set; }
            private int Freeze { get; set; }
            private int Shock { get; set; }
            private int Soak { get; set; }
            private int Poison { get; set; }
            private bool Invisible { get; set; }

            public Player(List<int> intAtts/*, List<bool> boolAtts*/)
            {
                Hitpoints = intAtts[0];
                BaseActions = intAtts[1];
                RemainingActions = 0;
                DefaultMovement = intAtts[2];
                TeamNumber = intAtts[3];
                Burn = 0;
                Freeze = 0;
                Shock = 0;
                Soak = 0;
                Poison = 0;
                Invisible = false;
            }
        }

    }
}
