using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAirResistance : MonoBehaviour
{
    public void ChangeBallDrag()
    {
        Toggle t = GameObject.Find("AirResistanceToggle").GetComponent<Toggle>();
        if (t.isOn)
        {
            //change label
            t.GetComponentInChildren<Text>().text = "Air Resistance On";

            float mass = GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().mass;
            GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 2.5f / (mass);

            //cap drag at 1
            if (GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag >= 1)
            {
                GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 1;
            }

            GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().drag = 0.5f;
        }
        else
        {
            t.GetComponentInChildren<Text>().text = "Air Resistance Off";
            GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 0;
            GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().drag = 0;
        }
    }
}
