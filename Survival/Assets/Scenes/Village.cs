using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    public void Start()
    { 
        int n = Random.Range(3, 6);        
        Villager myVillager = new Villager(n);
        int name = Random.Range(0, 20);
        string[] names = new string[20]
          {
                "Rose",
                "Ophelie",
                "Celeste",
                "Mérida",
                "Catrina",
                "Dean",
                "Will",
                "Lucas",
                "Dustin",
                "Mike",
                "Sophie",
                "Isabella",
                "Amelie",
                "Charlotte",
                "Milo",
                "Dante",
                "Ariel",
                "Suhail",
                "Jake",
                "David",
        };

        int age = Random.Range(15, 100);
        Debug.Log("¡Hola, citadino! Me llamo " + (names[n]) + ". Y tengo  " + age + " años.");
    }

    
}

public class Villager
{
    public GameObject[] ald;
    int villagers = Random.Range(3, 6);
    

    public Villager(int villagers)
    {
        this.villagers = villagers;
        ald = new GameObject[10];
 
        for (int j = 0; j < villagers; j++)
        {
            GameObject villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            villager.transform.position = posicion;
                     

        }
    }

    public void Check()
    {

    }
}
