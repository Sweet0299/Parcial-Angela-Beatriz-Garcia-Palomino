using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionLifeTime : MonoBehaviour
{
    private float life = 2F;

    void Awake()
    {
        Destroy(gameObject, life);
    }
}
