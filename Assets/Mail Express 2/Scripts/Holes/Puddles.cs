using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Puddles : MonoBehaviour
{
    [SerializeField] private Animator   animator_anim; //asignar en el prefab a el player
  
    private IEnumerator yaw() //se genera una condicion en el animator para activar una animacion con el nombre "Yaw_bo"
    {
        animator_anim.SetBool("Yaw_bo", true);
        yield return new WaitForSeconds(4);
        animator_anim.SetBool("Yaw_bo", false);
    }

    private void OnTriggerEnter(Collider col) //Ahi que activar el trigger en el hueco, el hueco debe ser un objeto que se intancie y se les ancla este escript
    {
        if (col.gameObject.name == "Player")
        {
            //ahi que definir que hara el carro, si se movera de un lado a otro o cambiara de carril, aqui o en la corrutina se aplicaria
            StartCoroutine(yaw());
            Destroy(gameObject);

        }
    }
}
