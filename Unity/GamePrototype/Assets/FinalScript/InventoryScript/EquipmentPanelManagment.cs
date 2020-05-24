using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentPanelManagment : MonoBehaviour
{
    public int Vitality;
    public int Stamina;
    public int Strength;
    public int Agility;
    public int Armour;
    public int Inteligence;
    public int Charisma;
    public int weaponReach;

    [SerializeField] PickUpItem[] pickUpItem;

    void FixedUpdate()
    {
        Vitality = 0;
        Stamina = 0;
        Strength = 0;
        Agility = 0;
        Armour = 0;
        Inteligence = 0;
        Charisma = 0;

        pickUpItem = transform.GetComponentsInChildren<PickUpItem>(true);

        for(int i=0; i<pickUpItem.Length; i++)
        {
            Vitality += pickUpItem[i].Vitality;
            Stamina += pickUpItem[i].Stamina;
            Strength += pickUpItem[i].Strength;
            Agility += pickUpItem[i].Agility;
            Armour += pickUpItem[i].Armour;
            Inteligence += pickUpItem[i].Inteligence;
            Charisma += pickUpItem[i].Charisma;

            if(pickUpItem[i].type.ToString() == "Weapon")
            {
                weaponReach = pickUpItem[i].weaponReach;
            }
            else
            {
                weaponReach = 0;
            }

        }
        
    }

}
