using UnityEngine;

public sealed class FunctionExtras : MonoBehaviour 
{
    public static FunctionExtras extraLives;

    public GameObject[]     objectsAdditional_go;
    public Transform[]      positionInstatiate_tr;
    public Transform        instantiateHere_tr;
    public int              timeMin_int;
    public int              timeMax_int;
    private bool            isSpawning_bo = false;
    private int             randomPosicion_int;
    private int             randomGameobjectIns_int;

/*Se usa en Clase AddLives*/    
    internal GameObject     liveExtra;
    private void Awake()
    {
        if(!extraLives)
        {
            extraLives = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
        randomPosicion_int = Random.Range(0,3);
        randomGameobjectIns_int = Random.Range(0,2);
/*SUGERENCA: Modificar la velocidad de los objectos que daran vidas extras */
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);

        if (!isSpawning_bo)
        {
            isSpawning_bo = true;
			InvokeRepeating("SpawnObject",timeMin_int,timeMax_int);
		}
	}
    private void SpawnObject()
    {
        liveExtra = Instantiate(objectsAdditional_go[randomGameobjectIns_int], positionInstatiate_tr[randomPosicion_int].position, transform.rotation);
        liveExtra.transform.parent = instantiateHere_tr;
        isSpawning_bo = false;
    }
}
