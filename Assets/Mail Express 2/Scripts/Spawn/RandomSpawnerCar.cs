using UnityEngine;
using System.Collections;

public class RandomSpawnerCar : MonoBehaviour
{
    public static RandomSpawnerCar randomSpawnerCar;
    
    [Header("Car Function")]
    public GameObject[]                     CarEnemy_go;
    public Transform[]                      positionInstatiate_tr;
    public Transform                        instantiateHere_tr;
    private int                             randomPosicion_int;
    [Header("Verificador")]
    [SerializeField] private bool           isSpawning_bo = false;
    [Header("Tiempo")]
    [SerializeField] private float          minTime_fl = 2;
    [SerializeField] private float          maxTime_fl = 4;
    
    private void Awake()
    {
        if(!randomSpawnerCar)
        {
            randomSpawnerCar = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
        randomPosicion_int = Random.Range(0,3);
        transform.Translate(Vector3.forward * 4 * Time.deltaTime);
        VelocityCarEnemy();
        StartCoroutine(CallVelocityCar());
      }
    public void VelocityCarEnemy()
    {
        if (!isSpawning_bo)
        {
            isSpawning_bo = true;
            int enemyIndex = Random.Range(0, CarEnemy_go.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime_fl, maxTime_fl)));
        }
    }
    private IEnumerator SpawnObject(int index, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        GameObject Car = Instantiate(CarEnemy_go[index], positionInstatiate_tr[randomPosicion_int].position, transform.rotation);
        Car.transform.parent = instantiateHere_tr;
        isSpawning_bo = false;
    }
    public IEnumerator CallVelocityCar()
    {
        yield return new WaitForSeconds(25);
        Time.timeScale = 2;
        minTime_fl = 0.3f;
        maxTime_fl = 0.8f;
    }
}