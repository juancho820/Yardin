using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour {

    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;


    void OnMouseEnter()
    {
        Debug.Log("entro");
        GetComponent<Image>().material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        GetComponent<Image>().material.color = originalColor;
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(GetComponent<RectTransform>().pivot, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            GetComponent<RectTransform>().pivot = rayPoint;
        }
    }
}
