using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour {
    public void Drag()
    {
        GameObject.Find("image").transform.position = Input.mousePosition;
        print("we are dragging the mouse");
    }

    public void Drop()
    {
        GameObject ph1 = GameObject.Find("BTN_GoToShip");
        GameObject ph2 = GameObject.Find("BTN_Explore");
        GameObject ph3 = GameObject.Find("BTN_Structure");
        GameObject ph4 = GameObject.Find("BTN_ScavengeForage");

        float distance = Vector3.Distance(GameObject.Find("image").transform.position, ph1.transform.position);
        float distance2 = Vector3.Distance(GameObject.Find("image").transform.position, ph2.transform.position);
        float distance3 = Vector3.Distance(GameObject.Find("image").transform.position, ph3.transform.position);
        float distance4 = Vector3.Distance(GameObject.Find("image").transform.position, ph4.transform.position);

        if (distance < 150)
        {
            GameObject.Find("image").transform.position = ph1.transform.position;
        }
        if (distance2 < 150)
        {
            GameObject.Find("image").transform.position = ph2.transform.position;
        }
        if (distance3 < 150)
        {
            GameObject.Find("image").transform.position = ph3.transform.position;
        }
        if (distance4 < 150)
        {
            GameObject.Find("image").transform.position = ph4.transform.position;
        }
    }
}
