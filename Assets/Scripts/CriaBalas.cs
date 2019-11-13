using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaBalas : MonoBehaviour
{
    public GameObject bala;
    public GameObject cano;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, new Vector3(
                cano.transform.position.x, 
                cano.transform.position.y, 
                cano.transform.position.z
            ), cano.transform.rotation);
        }
        
    }
}
