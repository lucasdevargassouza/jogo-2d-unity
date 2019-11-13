using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OncollisionEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("madeira"))
        {
            Destroy(outro);
        }
    }
}
