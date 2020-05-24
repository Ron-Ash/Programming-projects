using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EquipmentSlotFunctionality : MonoBehaviour, IPointerClickHandler
{
    public GameObject inventory;

    public void OnPointerClick(PointerEventData eventData)
    {

        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left click");
        }
        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log("Middle click");

        }
        else if (eventData.button == PointerEventData.InputButton.Right && transform.childCount > 0)
        {
            Debug.Log("Right click");
            transform.GetChild(0).transform.parent = inventory.transform;
        }
    }

    void FixedUpdate()
    {
        if(transform.childCount > 0)
        {
            transform.GetComponent<Image>().sprite = transform.GetChild(0).transform.GetComponent<SpriteRenderer>().sprite;
            transform.GetComponent<Image>().color = transform.GetChild(0).transform.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            transform.GetComponent<Image>().sprite = null;
            transform.GetComponent<Image>().color = Color.white;
        }
    }
}
