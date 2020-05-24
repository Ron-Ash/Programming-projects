using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float shift;
    Camera mainCamera;


    void Start()
    {
        mainCamera = GetComponent<Camera>();

    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+offset, -10);
    }



}
