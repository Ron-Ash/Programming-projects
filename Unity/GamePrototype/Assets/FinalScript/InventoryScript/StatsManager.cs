using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    public float MaxVitality;
    public float MaxStamina;
    [Space]
    public float Vitality;
    public float Stamina;
    [Space]
    public int Strength;
    public int Agility;
    public int Armour;
    public int Inteligence;
    public int Charisma;
    [Space]
    public GameObject equipmentPanel;
    [Space]
    public float drainRate;
    public int weaponReach;
    [Space]
    public int CustomStrength;
    public int CustomAgility;
    public int CustomArmour;
    public int CustomInteligence;
    public int CustomCharisma;
    [Space]
    public Text StrengthText;
    public Text AgilityText;
    public Text ArmourText;
    public Text InteligenceText;
    public Text CharismaText;

    EquipmentPanelManagment equipmentPanelManegment;

    // Start is called before the first frame update
    void Start()
    {
        equipmentPanelManegment = equipmentPanel.GetComponent<EquipmentPanelManagment>();
        Initial();
        Vitality = MaxVitality;
        Stamina = MaxStamina;
    }

    void Initial()
    {
        MaxVitality = 100;
        MaxStamina = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Initial();
        MaxStamina += equipmentPanelManegment.Stamina;
        MaxVitality += equipmentPanelManegment.Vitality;


        Strength = equipmentPanelManegment.Strength + CustomStrength;
        Agility = equipmentPanelManegment.Agility + CustomAgility;
        Armour = equipmentPanelManegment.Armour + CustomArmour;
        Inteligence = equipmentPanelManegment.Inteligence + CustomInteligence;
        Charisma = equipmentPanelManegment.Charisma + CustomCharisma;
        weaponReach = equipmentPanelManegment.weaponReach;

        IsDead();

        IsRunning();

        StrengthText.text = Strength.ToString();
        AgilityText.text = Agility.ToString();
        ArmourText.text = Armour.ToString();
        InteligenceText.text = Inteligence.ToString();
        CharismaText.text = Charisma.ToString();
    }

    void IsDead()
    {
        if(Vitality == 0 || Vitality < 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log("you are dead");
        }
        else if(Vitality < MaxVitality)
        {
            Vitality += drainRate;
        }
        else if(Vitality > MaxVitality)
        {
            Vitality = MaxVitality;
        }
    }

    void IsRunning()
    {
        if(Input.GetKey(KeyCode.LeftShift) && Stamina > 0)
        {
            Stamina -= drainRate;
        }
        else if(!Input.GetKey(KeyCode.LeftShift) && Stamina < MaxStamina)
        {
            Stamina += drainRate;
        }
        else if (Stamina > MaxStamina)
        {
            Stamina = MaxStamina;
        }
    }
}
