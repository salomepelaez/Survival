using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    public GameObject camara;
    private float speed = 0.1f;

    public void Hero()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }

        float rotacion = camara.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0.0f, rotacion, 0.0f);
    }

    float mouseX;
    float mouseY;
    public bool invertedMouse;

    public void CameraRot()
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

    public void Zombie()
    {
        
        int zombies = Random.Range(2, 6);
        for (int i = 0; i < zombies; i++)
        {
            GameObject zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            zombie.transform.position = posicion;
            Debug.Log("zombie");

            int color = Random.Range(0, 3);

            switch (color)
            {
                case 0:
                    zombie.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 1:
                    zombie.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 2:
                    zombie.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
            }
        }

    }

    public GameObject[] ald;

    public void Creacion()
    {
        ald = new GameObject[10];
        int villagers = Random.Range(3, 6);


        for (int j = 0; j < villagers; j++)
        {
            GameObject villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            villager.transform.position = posicion;
            Debug.Log("aldeano");


        }

    }
}
