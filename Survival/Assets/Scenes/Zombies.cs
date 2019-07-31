using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{

    public void Start()
    {         
        int n = Random.Range(4, 10); //El Random "n" es el que se encarga de escoger un número aleatorio entre 4 y 9, pues el 10 nolo toma en cuenta.       
        int nZombies = Random.Range(1, (n - 1));  //El número Random para Zombies es escogido entre 1 y la resta del primer Random menos uno.
        int v = n - nZombies; //El número de Villagers es escogido mediante la operación de resta entre el primer Random y el Random de Zombies.
        
        //El siguiente bloque de código es el que instancia los objetos, en este caso los zombies.
        for (int i = 0; i < nZombies; i++)
        {
            new Zombie(n);
        }
    }
}

public class Zombie //Esta es la clase secundaria, en la cual se encuentra el constructor
{
    public int myZombie = Random.Range(4, 10);
    public Zombie(int myZombie) //Se le agregaron parámetros al constructor.
    {
        this.myZombie = myZombie;        

        /*
         
         * Este bloque de código se encarga de crear un objeto primitivo, en este caso un cubo.
         * También le asigna una ubicación aleatoria utilizando un random y un Vector3.
         * También le asigna un color aleatorio y un mensaje dependiendo de este.
         
        */

        GameObject zZombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicion = new Vector3();
        posicion.x = Random.Range(-30, 30);
        posicion.z = Random.Range(-30, 30);
        zZombie.transform.position = posicion;

        int color = Random.Range(0, 3);

        switch (color)
        {
            case 0:
                zZombie.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 1:
                zZombie.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 2:
                zZombie.GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }

        //Como ya se mencionó antes, el siguiente bloque de código asigna un mensaje dependiendo del color.
        if(zZombie.GetComponent<Renderer>().material.color == Color.cyan)
        {
            Debug.Log("Soy un zombie color cyan" );
        }

        if (zZombie.GetComponent<Renderer>().material.color == Color.green)
        {
            Debug.Log("Soy un zombie color verde");
        }

        if (zZombie.GetComponent<Renderer>().material.color == Color.magenta)
        {
            Debug.Log("Soy un zombie color magenta");
        }
        
    }
}



