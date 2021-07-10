using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void attack()
    {
        Debug.Log(this.power + "attack");
    }
    public void damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "damage");
    }
}

public class variable : MonoBehaviour
{
    void Start()
    {
        Player myplayer = new Player();
        myplayer.attack();
        myplayer.damage(30);

    }
}
