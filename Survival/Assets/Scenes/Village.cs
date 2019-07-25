using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    public void Start()
    {
        Creacion();
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
