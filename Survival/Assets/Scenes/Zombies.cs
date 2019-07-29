using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    int n;
    int nZombies;
    int v;

    public void Start()
    {
        
        n = Random.Range(4, 10);
        nZombies = Random.Range(1, (n - 1));
        v = n - nZombies;
        Zombie z = new Zombie(nZombies);
        
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

        for (int i = 0; i < myZombie; i++)
        {
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
                Debug.Log("Cerebrossssss color Cyan. Grrr");
            }

            if (zZombie.GetComponent<Renderer>().material.color == Color.green)
            {
                Debug.Log("Zombie verrrde");
            }

            if (zZombie.GetComponent<Renderer>().material.color == Color.magenta)
            {
                Debug.Log("Zombie magenta. Cerebrosss");
            }

            zom[i] = zZombie;
        }

        
    }
}



