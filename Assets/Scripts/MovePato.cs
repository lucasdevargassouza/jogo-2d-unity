using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePato : MonoBehaviour
{
    public float vel = 2.5f;
    public int moeda = 0;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
            camera.gameObject.transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
            camera.gameObject.transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("moeda"))
        {
            moeda++;
            Destroy(outro.gameObject);
            print("Número de moedas: " + moeda);
        }
    }
}
