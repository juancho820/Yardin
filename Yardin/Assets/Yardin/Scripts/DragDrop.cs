using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour {
    #region Declarations

    [Header("Botones")]
    public GameObject btnGotoShip;
    public GameObject btnExplore;
    public GameObject btnBuildings;
    public GameObject btnForaje;
    [Header("Character")]
    public GameObject characterCards;
    #endregion
    public void Drag()
    {
        characterCards.transform.position = Input.mousePosition;
    }

    public void Drop()
    {

        float distance = Vector3.Distance(characterCards.transform.position, btnGotoShip.transform.position);
        float distance2 = Vector3.Distance(characterCards.transform.position, btnExplore.transform.position);
        float distance3 = Vector3.Distance(characterCards.transform.position, btnBuildings.transform.position);
        float distance4 = Vector3.Distance(characterCards.transform.position, btnForaje.transform.position);

        #region GoToShip
        if (distance < 150)
            characterCards.transform.position = btnGotoShip.transform.position;
        #endregion

        #region Explore
        if (distance2 < 150)
            characterCards.transform.position = btnExplore.transform.position;
        #endregion

        #region Buildings
        if (distance3 < 150)
            characterCards.transform.position = btnBuildings.transform.position;
        #endregion

        #region Foraje
        if (distance4 < 150)
            characterCards.transform.position = btnForaje.transform.position;
        #endregion

        if(distance>150 && distance2>150 && distance3 > 150 && distance4 > 150)
            characterCards.transform.localPosition = Vector3.zero;
    }
}
