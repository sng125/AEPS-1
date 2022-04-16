using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public void ResetEverything()
    {
        //move balls back to start positions
        GameObject.Find("GreenCircle").transform.position = new Vector2(-2,2);
        GameObject.Find("BlueCircle").transform.position = new Vector2(2, 2);

        //reset gravity to 0
        //Physics2D.gravity = new Vector2(0, 0);
        GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
