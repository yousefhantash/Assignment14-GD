using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("yousef", 80);
        Enemy enemy = new Enemy("ahmad", 90);

        Debug.Log("Player name: " + player.Name + "," + "Player health: " + player.Health);
        Debug.Log("Enemy name: " + enemy.Name + "," + "Enemy health: " + enemy.Health);

        player.Heal(20);
        Debug.Log("Player Health: " + player.Health);

        enemy.Attack(10);
        Debug.Log("Enemy Health: " + enemy.Health);
    }
}