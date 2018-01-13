using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[]         streetPrefab_go = new GameObject[5]; //Desde acá se controla la cantidad de calles diferentes que pueden instanciarse // Debe definirse en el inspector para agregar los Prefabs
    private float               secondsToInstantiate_fl; // Segundos que espera para instanciar siguiente prefab
    private int                 streetPrefabsQuantity_int; // Cantidad total de prefabs

    private void Awake()
    {
        secondsToInstantiate_fl = 1.8f;
        streetPrefabsQuantity_int = streetPrefab_go.Length;
    }

    private void Start()
    {
        StartCoroutine("InstantiateStreet");
    }

    private IEnumerator InstantiateStreet()
    {
        int selectedPrefab =Random.Range(0, streetPrefabsQuantity_int);
        yield return new WaitForSeconds(secondsToInstantiate_fl);
        Instantiate(streetPrefab_go[selectedPrefab], transform.position, Quaternion.identity);
        secondsToInstantiate_fl = 1.9755f;
        StartCoroutine("InstantiateStreet");
    }

}
