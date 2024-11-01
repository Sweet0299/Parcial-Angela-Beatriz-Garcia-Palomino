using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilingBackground : MonoBehaviour
{

    [Range(-1f, 1f)]
    private float scrollSpeed = 0.5f;
    private float offset;
    private Material miMaterial;


    void Start()
    {
        miMaterial = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / -10f;
        miMaterial.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
