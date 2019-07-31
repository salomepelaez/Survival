using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    public GameObject held; //Se creó un GameObject público para poder acceder a él desde el inspector.

    public void Start()
    {        
        GameObject s = Instantiate(held, Vector3.zero, Quaternion.identity); //Se instanció el GameObject como un prefab.

        int n = Random.Range(4, 10); //El Random "n" es el que se encarga de escoger un número aleatorio entre 4 y 9, pues el 10 nolo toma en cuenta.       
        int nZombies = Random.Range(1, (n - 1));  //El número Random para Zombies es escogido entre 1 y la resta del primer Random menos uno.
        int v = n - nZombies; //El número de Villagers es escogido mediante la operación de resta entre el primer Random y el Random de Zombies.

        string[] names = new string[20] //Se creó una matriz que almacena todos los nombres.
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

         //El siguiente bloque de código instancia los objetos, en este caso los Villagers.
        for (int j = 0; j < v; j++)
        {            
            new Villager(Random.Range(15, 101), names[Random.Range(0, names.Length)]);          
        }            
    }    
}

public class Villager //En esta clase secundaria se encuentra el constructor.
{
    string names; //Se declaró un string que luego se utilizará en la función.
    
    int villagers = Random.Range(4, 10);

    public Villager(int villagers, string names)  //En este caso el constructor debe recibir parámetros tanto del tipo Entero como del tipo Int.
    {
        this.villagers = villagers;
        this.names = names;
        
        //El siguiente bloque de código genera los objetos y les brinda una ubicación aleatoria.
        GameObject villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);
        villager.transform.position = posicion;
        Debug.Log(Message()); //Imprime la función.
    }

    //Esta función es la encargada de retornar un mensaje, con los nombres y las edades como complemento.
    string Message()
    {
        return "Hola soy " + (names) + ". Y tengo  " + Random.Range(15, 101) + " años.";
    }
    
}