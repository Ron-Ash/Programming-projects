using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPopUp : MonoBehaviour
{
    public Button button;
    public bool isUp;
    public float range;
    public GameObject inventoryPanel;

    void Start()
    {
        button.onClick.AddListener(Enlarge);
        isUp = false;
    }

    void Enlarge()
    {
        if(isUp == false)
        {
            inventoryPanel.transform.position = new Vector3(inventoryPanel.transform.position.x, 0, inventoryPanel.transform.position.z);
            isUp = true;
        }
        else if(isUp == true)
        {
            inventoryPanel.transform.position = new Vector3(inventoryPanel.transform.position.x, range, inventoryPanel.transform.position.z);
            isUp = false;
        }
    }
}
