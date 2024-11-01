using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    private GameObject explosionVfx;

    private float lifeProyectile = 2f;
    void Awake()
    {
        
        Destroy(gameObject, lifeProyectile); 
    }

    private void Start()
    {
        explosionVfx = Resources.Load<GameObject>("EXPLOSION");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ASTEROIDE"))
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ASTEROIDE"))
        {
            Instantiate(explosionVfx, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
