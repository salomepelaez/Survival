using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAim : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public bool invertedMouse;

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        if (invertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
            mouseY -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }

    
}
