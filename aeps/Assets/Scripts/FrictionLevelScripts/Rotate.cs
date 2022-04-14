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

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rotate = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            rotate = false;
        }
    }

    void OnMouseExit()
    {
        rotate = false;
    }
}
