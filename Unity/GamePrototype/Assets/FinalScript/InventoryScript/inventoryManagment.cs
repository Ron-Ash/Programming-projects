using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class inventoryManagment : MonoBehaviour
{
    public GameObject inventory;


    public Image[] slots;
    public SpriteRenderer[] pickedObjects;
    

    void OnValidate()
    {
        slots = this.GetComponentsInChildren<Image>(true);
        for(int i=0; i< slots.Length; i++)
        {
            slots[i].gameObject.name = i.ToString();
        }
        
    }

    void FixedUpdate()
    {
        pickedObjects = inventory.GetComponentsInChildren<SpriteRenderer>(true);
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].sprite = null;
            slots[i].color = Color.white;
        }
        for (int i = 0; i < pickedObjects.Length; i++)
        {
            slots[i].sprite = pickedObjects[i].sprite;
            slots[i].color = pickedObjects[i].color;
        }
    }
}
