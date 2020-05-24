using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlotFunctionality : MonoBehaviour, IPointerClickHandler
{
    public GameObject inventory;
    public GameObject equipmentPanel;
    public int slotName;
    GameObject isEquipable;
    public GameObject player;


    void OnValidate()
    {
        slotName = System.Convert.ToInt32(this.name);
    }


    public void OnPointerClick(PointerEventData eventData)
    {

        if (slotName < inventory.transform.childCount && eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left click");
            if(inventory.transform.GetChild(slotName).GetComponent<PickUpItem>().equipable == true)
            {
                isEquipable = equipmentPanel.transform.Find(inventory.transform.GetChild(slotName).GetComponent<PickUpItem>().type.ToString()).gameObject;

                if(isEquipable != null)
                {
                    if(isEquipable.transform.childCount <= 0)
                    {
                            inventory.transform.GetChild(slotName).transform.parent = isEquipable.transform;
                    }
                    else if(isEquipable.transform.childCount > 0)
                    {
                        for (int i = 0; i < isEquipable.transform.childCount; i++)
                        {
                            isEquipable.transform.GetChild(slotName).gameObject.SetActive(true);
                            isEquipable.transform.GetChild(slotName).gameObject.transform.position = player.transform.position;
                            isEquipable.transform.GetChild(i).parent = null;
                        }
                        inventory.transform.GetChild(slotName).transform.parent = isEquipable.transform;
                        
                    }
                }
                else
                {
                    Debug.Log("cannot equip");
                }
            }

        }

        else if (slotName < inventory.transform.childCount && eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log("Middle click");

        }
        else if (slotName < inventory.transform.childCount && eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right click");
            Debug.Log(this.name);
            inventory.transform.GetChild(slotName).gameObject.SetActive(true);
            inventory.transform.GetChild(slotName).transform.position = player.transform.position;
            inventory.transform.GetChild(slotName).transform.parent = null;
        }
    }
}
