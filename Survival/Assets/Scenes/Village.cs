using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{

    public void Start()
    {
        int n = Random.Range(4, 10);
        int nZombies = Random.Range(1, (n - 1));
        int v = n - nZombies;        
        Villager myVillager = new Villager(v);
                
    }

}

public class Villager
{
    public GameObject[] ald;
    int villagers = Random.Range(4, 10);
    

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
            VillagersNames();

            ald[j] = villager;
        }
        
    }

    public void VillagersNames()
    {
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
        
        int n = Random.Range(4, 10);
        int nZombies = Random.Range(1, (n - 1));
        int v = n - nZombies;
        int age = Random.Range(15, 100);
        Debug.Log("¡Hola, citadino! Me llamo " + (names[v]) + ". Y tengo  " + age + " años.");
    }
}
