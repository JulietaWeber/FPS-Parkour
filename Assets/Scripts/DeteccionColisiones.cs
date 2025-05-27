using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con " + collision.gameObject.name);
        // collision es al de abajo, si no solo, es el que cae
        Destroy(collision.gameObject);
    }
}
