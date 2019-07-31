using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{

    public void Start()
    {
        
        int n = Random.Range(4, 10);
        int  nZombies = Random.Range(1, (n - 1));
        int v = n - nZombies;
        
        for (int i = 0; i < nZombies; i++)
        {
            new Zombie(n);
        }


    }

}

public class Zombie
{
    public GameObject[] zom;
    public int myZombie = Random.Range(4, 10);
    public Zombie(int myZombie)
    {
        this.myZombie = myZombie;
        zom = new GameObject[10];

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



