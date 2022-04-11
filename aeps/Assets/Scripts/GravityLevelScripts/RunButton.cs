using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButton : MonoBehaviour
{
    public void WhenPressed()
    {
        Physics2D.gravity = new Vector2(0, -10);
    }
}