using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planedelete : MonoBehaviour
{
    public GameObject leftplane;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        logic.GameScore += 1;
        Destroy(gameObject);
    }
}
