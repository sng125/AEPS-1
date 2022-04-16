using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButton : MonoBehaviour
{
    public void WhenPressed()
    {
        GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().gravityScale = 1;
        GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().gravityScale = 1;
        //Physics2D.gravity = new Vector2(0, -10);
    }
}