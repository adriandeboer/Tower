using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlaneMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlaneLeft;
    public LeftPlaneMoveScript LeftPlaneMoveScript;
    public bool Spawned = false;
    public float moveSpeed;
    public float DeadZoneLeftSide;
    public GameObject PlaneRigth;
    
    
    void Start()
    {
        Spawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawned == true)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
        }

        if (transform.localPosition.x<DeadZoneLeftSide)
        {
            Destroy(PlaneRigth);
        }
        
    }
}
