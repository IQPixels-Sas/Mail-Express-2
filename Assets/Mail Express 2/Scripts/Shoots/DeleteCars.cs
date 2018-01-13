using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DeleteCars : MonoBehaviour
{

    [SerializeField]private Rigidbody       rocket_rb; // asiganar rayo
    [SerializeField]private Rigidbody       rocketAll_rb; //asignar ola
    [SerializeField]private float           speed_fl = 10f;
    [SerializeField]private float           distance_fl = 10f;

    public void Delete () //metodo para eliminar solo un carro que este enfrente
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(rocket_rb, transform.position, transform.rotation);
        //para que las balas funcionen deben activar el freeze en los ejes x,y en el rb
        rocketClone.velocity = transform.forward * speed_fl;
    }
    public void DeleteAll() //metodo para eliminar varios carros de toda la fila delantera
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(rocketAll_rb, new Vector3 (0,transform.position.y,transform.position.z + distance_fl ), transform.rotation);
        //para que las balas funcionen deben activar el freeze en los ejes x,y en el rb
        rocketClone.velocity = transform.forward * speed_fl;
    }
}
