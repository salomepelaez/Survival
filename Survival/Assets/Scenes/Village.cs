using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{

    public void Start()
    {


        int age = Random.Range(15, 100);
        int n = Random.Range(4, 10);
        int nZombies = Random.Range(1, (n - 1));       
        int v = n - nZombies;

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

        Villager myVillager = new Villager(v);
        Villager myVillager2 = new Villager(age, names);
    }
}

public class Villager
{
    private string[] names;
    public GameObject[] ald;
    int villagers = Random.Range(4, 10);
    int age = Random.Range(15, 100);

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
            
            ald[j] = villager;
        }
    }


    public Villager(int age, string[] names)
    {
        this.age = age;
        this.names = names;
        int n = Random.Range(4, 10);
        int nZombies = Random.Range(1, (n - 1));
        int v = n - nZombies;

        Debug.Log("¡Hola, citadino! Me llamo " + (names[v]) + ". Y tengo  " + age + " años.");
    }

    //Hasta acá funciona pero solo imprime una vez.
}