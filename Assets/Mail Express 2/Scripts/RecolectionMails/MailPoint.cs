using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailPoint : MonoBehaviour {


    private void OnTriggerEnter(Collider col) //Ahi que activar el trigger

    {
        if (col.gameObject.tag == "Player") 
        {
            //aqui se incerta la suma de la variable que determinemos como puntaje
            print("+5");
            Destroy(gameObject);
        }
    }
}
