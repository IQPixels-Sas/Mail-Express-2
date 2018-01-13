using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bullets : MonoBehaviour
{
 
    [SerializeField] private float      duration_fl =4; 
    
    private void Start()
    {
        Destroy(gameObject, duration_fl);
    }
    private void OnTriggerEnter(Collider col) //Ahi que activar el trigger
 
    {
        if (col.gameObject.tag == "Enemy") //los carros deben tener este nombre en el caso de que tegan nombres diferentes se cambia por un tag
        {
            Destroy(col.gameObject);
        }
    }
  
}
