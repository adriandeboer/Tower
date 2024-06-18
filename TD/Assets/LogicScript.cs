using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int GameScore;

    public Text ScoreText;

    public float MoveSpeed;

    public int GamePhaseOne; // Score für GamePhase
    public float GamePhaseOneSpeedB;// Speed Multiplier

    public int GamePhaseTwo;
    public float GamePhaseTwoSpeedB;

    public int GamePhaseThree;
    public float GamePhaseThreeSpeedB;

    public int GamePhaseFour;
    public int HighestCap;
    public float GamePhaseFourSpeedB;

    public bool PhaseOneEntered = false;

    public bool PhaseTwoEntered = false;

    public bool PhaseThreeEntered = false;

    public bool PhaseFourEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(GameScore);
      ScoreText.text = GameScore.ToString();

      if (GameScore>GamePhaseOne && GameScore<=GamePhaseTwo && PhaseOneEntered == false) // Phase 1
      {
          MoveSpeed *= GamePhaseOneSpeedB;
          PhaseOneEntered = true;

      }

      if (GameScore >= GamePhaseTwo && GameScore< GamePhaseThree && PhaseTwoEntered == false) // Phase 2
      {
          MoveSpeed *= GamePhaseTwoSpeedB;
          PhaseTwoEntered = true;
      }

      if (GameScore >= GamePhaseThree && GameScore < GamePhaseFour && PhaseThreeEntered == false)
      {
          MoveSpeed *= GamePhaseThreeSpeedB;
          PhaseThreeEntered = true;
      }

      if (GameScore >= GamePhaseFour && GameScore < HighestCap && PhaseFourEntered == false)
      {
          MoveSpeed *= GamePhaseFourSpeedB;
          PhaseFourEntered = true;
      }

    }
}
