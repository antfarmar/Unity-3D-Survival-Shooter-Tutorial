using UnityEngine;
using System.Collections;

[System.Serializable]
public class WeaponObject : ScriptableObject
{

    public string weaponName = "Weapon Name Here";
    public int cost = 50;
    public string description;

    public float fireRate = .5f;
    public int damagePerShot = 10;
    public float range = 100;

}