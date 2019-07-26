using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public void Start()
    {
        int n = Random.Range(2, 6);
        Zombie z = new Zombie(n);
    }

}

public class Zombie
{
    public int myZombie = Random.Range(2, 6);
    public Zombie(int myZombie)
    {
        this.myZombie = myZombie;
        for (int i = 0; i < myZombie; i++)
        {
            GameObject zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 posicion = new Vector3();
            posicion.x = Random.Range(-30, 30);
            posicion.z = Random.Range(-30, 30);
            zombie.transform.position = posicion;

            int color = Random.Range(0, 3);

            switch (color)
            {
                case 0:
                    zombie.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 1:
                    zombie.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 2:
                    zombie.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
            }

            if(zombie.GetComponent<Renderer>().material.color == Color.cyan)
            {
                Debug.Log("Cerebrossssss color Cyan. Grrr");
            }

            if (zombie.GetComponent<Renderer>().material.color == Color.green)
            {
                Debug.Log("Zombie verrrde");
            }

            if (zombie.GetComponent<Renderer>().material.color == Color.magenta)
            {
                Debug.Log("Zombie magenta. Cerebrosss");
            }
        }

        
    }
}



