using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Helmet,
    ChestArmour,
    Shoes,
    Weapon,
    Potion,
    QuestItem,
    Food,
    Coin,
    None,
}

public class PickUpItem : MonoBehaviour
{
    public Type type;
    public int weaponReach;
    [Space]
    public bool stackable;
    public int amount;
    public bool equipable;
    [Space]
    public int Vitality;
    public int Stamina;
    public int Strength;
    public int Agility;
    public int Armour;
    public int Inteligence;
    public int Charisma;
    
    void OnValidate()
    {
        if (equipable == false)
        {
            Vitality = 0;
            Stamina = 0;
            Strength = 0;
            Agility = 0;
            Armour = 0;
            Inteligence = 0;
            Charisma = 0;
        }
        if(stackable == false)
        {
            amount = 1;
        }
        if(type.ToString() != "Weapon")
        {
            weaponReach = 0;
        }
    }

}
