using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int GameScore;

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(GameScore);
      ScoreText.text = GameScore.ToString();
    }
}
