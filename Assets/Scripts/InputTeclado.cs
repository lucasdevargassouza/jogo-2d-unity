using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTeclado : MonoBehaviour
{
    public float vel = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveElemento();
    }

    private void moveElemento()
    {
        float Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        // float Horizontal = Input.GetAxis("Mouse X") * Time.deltaTime;
        // float Vertical = Input.GetAxis("Mouse Y") * Time.deltaTime;


        transform.Translate(new Vector3(Horizontal, 0, 0));
        transform.Translate(new Vector3(0, Vertical, 0));
    }
}
