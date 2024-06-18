using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class LeftPlaneMoveScript : MonoBehaviour
{
    public bool spawned;
    public float DeadzoneRigthside;
    public GameObject PlaneLeft;
    public LogicScript logic;
    
    
    void Start()
    {
        spawned = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == true)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * logic.MoveSpeed)); // Moves the Plane in the direction of the tower. In the other script: getComp
        }
        
        if (transform.localPosition.x>DeadzoneRigthside)
        {
            Destroy(PlaneLeft);
        }
    }
}
