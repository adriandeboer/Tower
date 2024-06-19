using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptLeft : MonoBehaviour
{
    public float Spawntime;


    public float Spawnheigth;

    public float lowestpoint = -2;

    public float highestpoint = 1;

    public GameObject PlaneRigth;

    // Start is called before the first frame update
    void Start()
    {
        RestartSpawntimer();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Spawntime > 0)
        {
            Spawntime -= Time.deltaTime;
        }

        if (Spawntime < 0)
        {
            SpawnRigth();
            RestartSpawntimer();
        }



    }

    public void RestartSpawntimer()
    {
        Spawntime = Random.Range(2, 7);
    }

    void SpawnRigth()
    {
        Spawnheigth = Random.Range(0, 5);
        Instantiate(PlaneRigth, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }

}
