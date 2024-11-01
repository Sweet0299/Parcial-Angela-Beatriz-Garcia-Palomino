using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private float movespeed = 3f;
    Vector3 right = new Vector3(0f, 90f, 0f);
    Vector3 left = new Vector3(0f, -90f, 0f);

    private float posMin = -7.2f;
    private float posMax = 7.2f;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;

        // Movimiento a la izquierda
        if (Input.GetKey(KeyCode.A) && posX > posMin)
        {
            transform.position -= transform.right * movespeed * Time.deltaTime;
        }
        // Movimiento a la derecha
        if (Input.GetKey(KeyCode.D) && posX < posMax)
        {
            transform.position += transform.right * movespeed * Time.deltaTime;
        }

        // Ajuste si sobrepasa los límites
        if (posX < posMin)
        {
            transform.position = new Vector3(posMin, transform.position.y, transform.position.z);
        }
        else if (posX > posMax)
        {
            transform.position = new Vector3(posMax, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ASTEROIDE"))
        {
            Debug.Log("Game Over");
            GameManager.Instance.Jugar();
        }
    }
}
