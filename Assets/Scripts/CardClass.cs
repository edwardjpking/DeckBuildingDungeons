using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int pointValue;
    public string cardDescription;


    public Card() {

    }

    public Card(int Id, string CardName, int PointValue, string CardDescription) {
        id = Id;
        cardName = CardName;
        pointValue = PointValue;
        cardDescription = CardDescription;
    }

    /*

    private PlayerClass pc;
    public List<pc.Player> Targets;





    // Move
    public void Move (int range, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {

        }
    }

    
    // Attack
    public void Attack (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Hitpoints -= x;
        }
    }

    
    // Draw a card
    public void Draw (int x)
    {
        for (int i = 0; i < x + 1; i ++)
        {
            Deck.Draw();
        }
    }

    // Discard a card
    public void Discard (int x)
    {
        for (int i = 0; i < x + 1; i ++)
        {
            Hand.Discard();
        }
    }

    // Burn
    public void Burn (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Burn += x;
        }
    }

    // Freeze
    public void Freeze (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Freeze += x;
        }
    }

    // Shock
    public void Shock (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Hitpoints -= 2*x;
            target.Shock += x;
        }
    }

    // Soak
    public void Soak (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Soak += x;
        }
    }

    // Invisible
    public void Invisible (List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Invisible = true;
        }
    }

    // Poison
    public void Poison (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Poison += x;
        }
    }

    // Heal
    public void Heal (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.Hitpoints += x;
        }
    }

    // Summon - unfinished
    public void Summon (summon)
    {

    }
    
    // Take another action
    public void TakeAnotherAction (int x, List<Player.PlayerClass.Player> Targets)
    {
        foreach (Player.PlayerClass.Player target in Targets)
        {
            target.RemainingActions += x;
        }
    }
    */
}