using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public GameObject camara;
    private float speed = 0.1f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }

        float rotacion = camara.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0.0f, rotacion, 0.0f);

    }
}
