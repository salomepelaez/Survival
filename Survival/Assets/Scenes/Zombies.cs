using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{

    public void Start()
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

            int color = Random.Range(0, 6);

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
}



