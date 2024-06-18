using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlaneMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlaneLeft;
    public LeftPlaneMoveScript LeftPlaneMoveScript;
    public bool Spawned = false;
    public float DeadZoneLeftSide;
    public GameObject PlaneRigth;
    public LogicScript logic;
    
    
    void Start()
    {
        Spawned = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawned == true)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * logic.MoveSpeed));
        }

        if (transform.localPosition.x<DeadZoneLeftSide)
        {
            Destroy(PlaneRigth);
        }
        
    }
}
