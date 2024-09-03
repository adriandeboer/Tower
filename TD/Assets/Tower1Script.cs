using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tower1Script : MonoBehaviour
{

    public int TowerHealth = 5;
    public bool TowerIsAlive = true;
    public bool TowerhitbyPlane = false;
    public Scene RespawnScene;
    public Scene SampleScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TowerIsAlive == false)
        {
            GameOver();
        }

        if (TowerHealth  == 0) 
        {
            TowerIsAlive = false;
        }

    }

    public void DamageTower()
    {
        TowerHealth -= 1;
        Debug.Log("Tower damaged Tower Health = ");
        Debug.Log(TowerHealth);
        TowerhitbyPlane = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DamageTower();
    }

    public void GameOver()
    {
        SceneVisibilityManager.instance.Hide(SampleScene);
        SceneVisibilityManager.instance.Show(RespawnScene);
    }
}
