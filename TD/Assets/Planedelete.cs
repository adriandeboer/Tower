using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planedelete : MonoBehaviour
{
    public GameObject leftplane;
    public LogicScript logic;
    public Tower1Script Tower;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Tower = GameObject.FindGameObjectWithTag("Tower").GetComponent<Tower1Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tower.TowerhitbyPlane == true && Tower.TowerIsAlive == true)
        {
            Destroy(leftplane);
        }
    }
    private void OnMouseDown()
    {
        logic.GameScore += 1;
        Destroy(gameObject);
    }
}
