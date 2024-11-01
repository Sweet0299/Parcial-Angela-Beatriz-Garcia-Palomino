using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    private float speed = 3.7f; 
    private float life = 10f; 

    // Velocidad de rotación
    public float rotacionVelocidad = 45f;

    void Awake()
    {
        Destroy(gameObject, life); 
    }

    void Update()
    {
        
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);

      
        transform.Rotate(0.0f, rotacionVelocidad * Time.deltaTime, 0.0f);
    }

}
