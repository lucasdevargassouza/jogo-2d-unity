﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour
{
    public float forca = 500f;
    public Rigidbody2D itemPular;
    public bool liberaPulo = false;
    public int duplo = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && duplo > 0)
        {
            duplo--;
            itemPular.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            duplo = 2;
        }
    }

}
