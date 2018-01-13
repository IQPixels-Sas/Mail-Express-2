using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearn : MonoBehaviour {

    void OnTriggerEnter(Collider col) //Ahi que activar el trigger
    {
        if (col.gameObject.tag == "Houses" || col.gameObject.tag == "Enemy") //Poner el tag a las casas
        {
            Destroy(col.gameObject);
        }
    }
}
