using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVelocityOnClick : MonoBehaviour
{
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld)
        {
            ResetVelocity();
        }
    }

    private void ResetVelocity()
    {
        Rigidbody2D rigid = this.gameObject.GetComponent<Rigidbody2D>();

        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = 0;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;        
    }
}
