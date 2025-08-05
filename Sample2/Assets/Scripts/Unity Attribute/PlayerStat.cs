using System;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public enum Trait
    {
        FastLeg,
        SlowLeg,
        Strong,
        Weak,
        Positive,
        Negative,
        Swearer
    }
    public enum HumanRace
    {
        Human,
        Orc,
        Elf
    }

    public enum Equipment
    {
        LeatherCloths,
        IronArmor,
        BulletproofVest
    }

    public enum Weapon
    {
        Spear,
        Dagger,
        LongSword,
        Bow,
        CrossBow,
        Revolver,
        ShotGun,
        Rifle,
        RayGun
    }

    [Flags]
    public enum Inventory
    {
        Food = 1 << 0,
        Cigarette = 1 << 1,
        Alcohol = 1 << 2,
        Bandage = 1 << 3,
        SmokeShell = 1 << 4
    }

    public enum Disease
    {
        None,
        flu,
        malaria,
        dementia,
        cancer
    }

    [Header("Player")]
    public HumanRace race;
    public Trait trait;
    public int Age;
    public Disease disease;
    [Range(0, 100)]
    public int Mood;
    [Range(0, 100)]
    public int HP;
    [Header("Skill")]
    public int melee;
    public int shooting;
    public int building;
    public int gardening;
    public int medical;
    public int social;

    [Header("Inventory")]
    public Equipment equipment;
    public Weapon weapon;
    public Inventory inventory;


}
