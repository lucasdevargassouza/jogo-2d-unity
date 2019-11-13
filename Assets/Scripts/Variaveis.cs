using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{

    public float vel = 0.1f;
    public Renderer quad;

    private Vector2 offset;

    void Start()
    { }

    void Update()
    {
        offset = new Vector2(vel * Time.deltaTime, 0);
        quad.material.mainTextureOffset += offset;
        
    }
}
