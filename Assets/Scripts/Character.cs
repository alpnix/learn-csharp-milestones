using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon {
    public string Name;
    public int Damage;

    // Constructor to initialize the struct
    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
}


public class Character {
    public string name; 
    public int health;



    public Character(string name, int health) {
        this.name = name;
        this.health = health;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Name: {name}, Health: {health}");
    }

}


public class Paladin : Character
{
    public Weapon Weapon { get; private set; }

    // Constructor
    public Paladin(string name, int health, Weapon weapon) : base(name, health)
    {
        Weapon = weapon;
    }

    // Override PrintStatsInfo
    public override void PrintStatsInfo()
    {
        base.PrintStatsInfo();
        Debug.Log($"Weapon: {Weapon.Name}, Damage: {Weapon.Damage}");
    }
}
