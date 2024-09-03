using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RespawnScript : MonoBehaviour
{
    public Button RespawnButton;
    public bool OngoingGame = false;
    

    public Scene SampleScene;
    // Start is called before the first frame update
    void Start()
    {
        if (RespawnButton != null)
        {
            RespawnButton.onClick.AddListener(OnButtonClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClick()
    {
      
    }
}
