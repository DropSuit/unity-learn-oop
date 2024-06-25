using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject player;
    public float zOffSet;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void LateUpdate()
    {
        float xLocation = player.transform.position.x;
        float yLocation = player.transform.position.y;

        transform.position = new Vector3(xLocation, yLocation,zOffSet);
    }
}
