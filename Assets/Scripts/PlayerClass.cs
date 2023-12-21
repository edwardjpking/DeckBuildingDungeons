using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public class Player
    {
        // Define variables
        public int Hitpoints
        { get; set; }
        public int BaseActions
        { get; set; }
        public int RemainingActions
        { get; set; }
        public int TeamNumber
        { get; set; }
        public bool Fire
        { get; set; }
        public bool Ice
        { get; set; }
        public bool Lightning
        { get; set; }
        public bool Water
        { get; set; }
        public bool Poison
        { get; set; }
        public bool Invisible
        { get; set; }
        public int Burn
        { get; set; }
        public int PoisonValue
        { get; set; }


        // Instantiate variables
        public Player(int HP, int BA, int RA, int TN)
        {
            Hitpoints = HP;
            BaseActions = BA;
            RemainingActions = RA;
            TeamNumber = TN;
            Fire = false;
            Ice = false;
            Lightning = false;
            Water = false;
            Poison = false;
            Invisible = false;
            Burn = 0;
            PoisonValue = 0;
        }

    }
}
