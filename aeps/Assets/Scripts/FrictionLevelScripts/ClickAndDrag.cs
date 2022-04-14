using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (isBeingHeld)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
