using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour
{
    private float rotZ;
    private float rotationSpeed = 75;
    private bool rotate = false;

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            rotZ += Time.deltaTime * rotationSpeed;

            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
    }

    //If mouse is hovering over object collider
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) //If right mouse button clicks, rotate
        {
            rotate = true;
        }
        if (Input.GetMouseButtonUp(1)) //If right mouse button releases, stop rotating
        {
            rotate = false;
        }
    }

    // If mouse button exits collider area, always stop rotating
    void OnMouseExit()
    {
        rotate = false;
    }
}
