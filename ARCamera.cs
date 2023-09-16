using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCamera : MonoBehaviour
{
    public float speedH = 2.0F;
    public float speedV = 2.0F;

    private float yaw = 0.0f;
    private float pitch = 0.0f; 
    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
