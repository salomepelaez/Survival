using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    public GameObject held; //Se creó un GameObject público para poder acceder a él desde el inspector.

    public void Start()
    {        
        GameObject s = Instantiate(held, Vector3.zero, Quaternion.identity); //Se instanció el GameObject como un prefab.

        int n = Random.Range(4, 9); //El Random "n" es el que se encarga de escoger un número aleatorio entre 4 y 9, pues el 10 nolo toma en cuenta.       
        int nZombies = Random.Range(1, (n - 1));  //El número Random para Zombies es escogido entre 1 y la resta del primer Random menos uno.
        int v = n - nZombies; //El número de Villagers es escogido mediante la operación de resta entre el primer Random y el Random de Zombies.
        
        string[] names = new string[20]; //Se creó una matriz que almacena todos los nombres.


        names[0] = "Rose";
        names[1] = "Ophelie";
        names[2] = "Celeste";
        names[3] = "Mérida";
        names[4] = "Catrina";
        names[5] = "Dean";
        names[6] = "Will";
        names[7] = "Lucas";
        names[8] = "Dustin";
        names[9] = "Mike";
        names[10] = "Sophie";
        names[11] = "Isabella";
        names[12] = "Amelie";
        names[13] = "Charlotte";
        names[14] = "Milo";
        names[15] = "Dante";
        names[16] = "Ariel";
        names[17] = "Suhail";
        names[18] = "Jake";
        names[19] = "David";
        

        //El siguiente bloque de código instancia los objetos, en este caso los Villagers.
        for (int j = 0; j < v; j++)
        {            
            new Villager(v, names[Random.Range(0, names.Length)]);          
        }

        //El siguiente bloque de código es el que instancia los objetos, en este caso los zombies.
        for (int i = 0; i < nZombies; i++)
        {
            new Zombie(n);
        }
    }    
}

public class Villager //En esta clase secundaria se encuentra el constructor.
{
    string names; //Se declaró un string que luego se utilizará en la función.
    public GameObject[] ald;
    int villagers = Random.Range(4, 9);

    public Villager(int villagers, string names)  //En este caso el constructor debe recibir parámetros tanto del tipo Entero como del tipo Int.
    {
        this.villagers = villagers;
        this.names = names;
        ald = new GameObject[10];

        //El siguiente bloque de código genera los objetos y les brinda una ubicación aleatoria.
        GameObject villager = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);
        villager.transform.position = posicion;

        ald[villagers] = villager;

        Debug.Log(Message()); //Imprime la función.
    }

    //Esta función es la encargada de retornar un mensaje, con los nombres y las edades como complemento.
    string Message()
    {
        return "Hola soy " + (names) + ". Y tengo  " + Random.Range(15, 101) + " años.";
    }
    
}