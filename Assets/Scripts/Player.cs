using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }
}