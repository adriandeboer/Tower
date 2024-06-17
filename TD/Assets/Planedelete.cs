using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planedelete : MonoBehaviour
{
    public GameObject leftplane;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
