using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int power;
    private int health;
    private string name;

    public Player(int health, int power, string name)
    {
        this.Health = health;
        this.Power = power;
        this.Name = name;
    }

    public int Health
    {
        get { return health;}
        set { health= value; }
    }

    public string Name
    {
        get { return name; }
        set { name= value; }
    }

    public int Power
    {
        get { return power;  }
        set { power = value; }
    }

    public void Info()
    {
        Debug.Log("Name: " + this.name);
        Debug.Log("Power: " + this.power);
        Debug.Log("Health: " + this.health);
    }

    public virtual void Attack()
    {
        Debug.Log("Player  is  Attacking...");
    }
}
