using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(int damage)
    {
        Health -= damage;
    }
}
