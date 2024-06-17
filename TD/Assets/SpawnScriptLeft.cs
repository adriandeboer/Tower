using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawnScript : MonoBehaviour
{
    public float Spawntime;

    public GameObject PlaneLeft;

    public float Spawnheigth;

    public float lowestpoint = -2;

    public float highestpoint = 1;

    // Start is called before the first frame update
    void Start()
    {
        RestartSpawnTimer();
    }

    // Update is called once per frame
    void Update()
    {


        if (Spawntime > 0)
        {
            Spawntime = Spawntime - Time.deltaTime;
        }

        if (Spawntime < 0)
        {
            RestartSpawnTimer();
            SpawnLeft();
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnLeft();
        }


    }

    public void RestartSpawnTimer()
    {
        Spawntime = Random.Range(2, 7);
    }

    void SpawnLeft()
    {
        Spawnheigth = Random.Range(0,5);
        Instantiate(PlaneLeft, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        
    }

    
}

