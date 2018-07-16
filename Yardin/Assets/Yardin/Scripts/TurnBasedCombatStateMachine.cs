using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    public int numeroAlly;
    public int numeroEnemy;

    public GameObject ally, enemy;


    private BattleStates currentState;

	// Use this for initialization
	void Start () {
        currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case (BattleStates.START):
                for (int i = 0; i < numeroAlly; i++)
                {
                    Transform child = ally.transform.GetChild(i);
                    child.gameObject.SetActive(true);
                }
                for (int i = 0; i < numeroEnemy; i++)
                {
                    Transform child = enemy.transform.GetChild(i);
                    child.gameObject.SetActive(true);
                }
                break;
            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;
        }
	}
}
