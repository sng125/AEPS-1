using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
