using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject inventory;
    public GameObject interactedGameObject;



    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactedGameObject && interactedGameObject.tag == "Interactable")
        {
            
            if (interactedGameObject.GetComponent<PickUpItem>() == null)
            {
                Debug.Log("Hello");
            }
            else if (interactedGameObject.GetComponent<PickUpItem>() != null && inventory.transform.childCount < 20)
            {
                interactedGameObject.transform.position = transform.position;
                interactedGameObject.transform.parent = inventory.transform;
                interactedGameObject.SetActive(false);
            }
            interactedGameObject = null;
        }
    }

    void OnTriggerEnter2D(Collider2D interacted)
    {
        interactedGameObject = interacted.gameObject;
    }
    void OnTriggerExit2D(Collider2D interacted)
    {
        interactedGameObject = null;
    }


}
