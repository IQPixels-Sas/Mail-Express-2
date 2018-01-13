using UnityEngine;
using System.Collections;

public sealed class RandomSpawnerCarEnemy : MonoBehaviour
{
    [Header("Generation control")]
    [SerializeField]private float               controlTimeGeneration_fl;
    [SerializeField] private float              MaxTimeGenerationMails_fl;
    [SerializeField] private Transform[]        positionInstatiate_tr;

    [Header("Stage generation ramdom Mails")]
    [SerializeField]private Transform           instantiateHere_tr;
    [SerializeField] private GameObject[]       moduleMailRing_go;
    [SerializeField] private GameObject[]       moduleMailLeft_go;
    
    [Header("Stage generation ramdom Houses")]
    [SerializeField] private Transform          mainEcene_tr;
    [SerializeField] private GameObject[]       moduleLeft_go;
    [SerializeField] private GameObject[]       moduleRing_go;


    private bool                                StageGenerationControlLeft_bol = true;
    private bool                                StageGenerationControlRight_bol = true;
    private float                               time_fl;
    private float                               timeRamdom_fl;
    private float                               RamdomTime_fl;
    private int                                 randomPosicion_int;

    private void Update()
    {
        randomPosicion_int = Random.Range(0, positionInstatiate_tr.Length);
        time_fl += Time.deltaTime;
        timeRamdom_fl += Time.deltaTime;
        
        if (time_fl >= controlTimeGeneration_fl)
        {
            if (StageGenerationControlLeft_bol)
            {
                time_fl = 0;
                GenerateLeft();
            }
            else
            {
                GenerateLeftMail();
            }

            if (StageGenerationControlRight_bol)
            {
                time_fl = 0;
                GenerateRing();
            }
            else
            {
                GenerateRingMail();
            }
        }
        if (timeRamdom_fl >= RamdomTime_fl)
        {
            RamdomTime_fl = Random.Range(MaxTimeGenerationMails_fl, 4);  
            timeRamdom_fl = 0;
            Ramdomgenerator();
        }
    }

public void Ramdomgenerator() 
    {
        switch (randomPosicion_int)
        {
            case 0:
                StageGenerationControlRight_bol = false;
                break;
                
            case 1:
                StageGenerationControlLeft_bol = false;
                break;
        }
    }
    //estas funciones se encargan de genrar a cada lado un modulo
    void GenerateLeft()
    {
        int ramdomModuleLeft_int = Random.Range(0, moduleLeft_go.Length);
        GameObject ModuleLeft_go = Instantiate(moduleLeft_go[ramdomModuleLeft_int], positionInstatiate_tr[0].position, transform.rotation);
        ModuleLeft_go.transform.parent = mainEcene_tr;

    }

    void GenerateLeftMail()
    {
        StageGenerationControlLeft_bol = true;
        int ramdomModuleLeftMail_int = Random.Range(0, moduleMailLeft_go.Length);
        GameObject mail = Instantiate(moduleMailLeft_go[ramdomModuleLeftMail_int], positionInstatiate_tr[0].position, transform.rotation);
        mail.transform.parent = instantiateHere_tr;

    }
    void GenerateRing()
    {
        int ramdomModuleRing_int = Random.Range(0, moduleRing_go.Length);
        GameObject Modulering_go = Instantiate(moduleRing_go[ramdomModuleRing_int], positionInstatiate_tr[1].position, transform.rotation);
        Modulering_go.transform.parent = mainEcene_tr;

    }

    void GenerateRingMail()
    {
        StageGenerationControlRight_bol = true;
        int ramdomModuleRingMail_int = Random.Range(0, moduleMailRing_go.Length);
        GameObject mail = Instantiate(moduleMailRing_go[ramdomModuleRingMail_int], positionInstatiate_tr[1].position, transform.rotation);
        mail.transform.parent = instantiateHere_tr;

    }
}