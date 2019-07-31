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

 
        for (int j = 0; j < v; j++)
        {
            
            new Villager(Random.Range(15, 101), names[Random.Range(0, names.Length)]);
            

        }
                
        

       
    }

    
}

public class Villager
{
    string names;
    
    int villagers = Random.Range(4, 10);

    public Villager(int villagers, string names)
    {
        this.villagers = villagers;
        this.names = names;
                     
        GameObject villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);
        villager.transform.position = posicion;
        Debug.Log(Message());
    }

    string Message()
    {
        return "Hola soy " + (names) + ". Y tengo  " + Random.Range(15, 101) + " años.";
    }
    
}