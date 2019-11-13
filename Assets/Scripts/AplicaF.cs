using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicaF : MonoBehaviour
{
    public float forca = 250f;
    public Rigidbody2D bola;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("bola")) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
            }
        }
    }
}
