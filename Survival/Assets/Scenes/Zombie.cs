using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombie //Esta es la clase secundaria, en la cual se encuentra el constructor
{
    public GameObject[] zom;
    public int myZombie = Random.Range(4, 9);
    public Zombie(int myZombie) //Se le agregaron parámetros al constructor.
    {
        this.myZombie = myZombie;
        zom = new GameObject[10];

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

        zom[myZombie] = zZombie;
    }
}



