using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Rigidbody           rigidbody_rb;
    private float               speed_fl; //Velocidad de recorrido de la carretera 
    private float               destroySeconds_fl; //Segundo en el que se destruye cada instancia

    private void Awake()
    {
        rigidbody_rb = GetComponent<Rigidbody>();
        speed_fl = .1f;
        destroySeconds_fl = 10f; 
    }

    private void Start()
    {
        Destroy(gameObject, destroySeconds_fl);
    }

    private void FixedUpdate ()
    {
        rigidbody_rb.MovePosition(transform.position - transform.forward * speed_fl);
	}
}
