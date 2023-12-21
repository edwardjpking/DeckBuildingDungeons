// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using PlayerClass;

// public class CardClass : MonoBehaviour
// {
//     public class Card
//     {
//         public int pointValue { get; set; }
//         public list<Player> Targets

//         // Move
//         public void Move (x, HexDirections)
//         {

//         }

//         // Attack
//         public void Attack (x, Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Hitpoints -= x;
//             }
//         }

//         // Draw a card
//         public void Draw (x)
//         {
//             for (int i = 0; i < x + 1; i ++)
//             {
//                 Deck.Draw();
//             }
//         }

//         // Discard a card
//         public void Discard (x)
//         {
//             for (int i = 0; i < x + 1; i ++)
//             {
//                 Hand.Discard();
//             }
//         }

//         // Burn
//         public void Burn (x, Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Burn += x;
//                 target.Fire = true;
//             }
//         }

//         // Freeze
//         public void Freeze (Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Ice = true;
//             }
//         }

//         // Shock
//         public void Shock (Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Hitpoints -= 2;
//                 target.Lightning = true;
//             }
//         }

//         // Soak
//         public void Soak (Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Water = true;
//             }
//         }

//         // Invisible
//         public void Invisible (Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Invisible = true;
//             }
//         }

//         // Poison
//         public void Poison (x, Targets)
//         {
//             foreach (target in Targets)
//             {
//                 Targets.Poison = true;
//                 target.PoisonValue += x;
//             }
//         }

//         // Heal
//         public void Heal (x, Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.Hitpoints += x;
//             }
//         }

//         // Summon - unfinished
//         public void Summon (summon)
//         {

//         }

//         // Steamroll
//         public void Steamroll (x, Targets)
//         {
//             foreach (target in Targets)
//             {
//                 target.RemainingActions += x;
//             }
//         }
//     }
// }