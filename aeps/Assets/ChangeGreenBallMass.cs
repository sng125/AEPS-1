using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeGreenBallMass : MonoBehaviour
{

    float scale = 1;
    float mass = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeMass()
    {
        Slider mySlider = GameObject.Find("GreenBallMassSlider").GetComponent<Slider>();
        float mySliderVal = mySlider.value * 10;
        mass = mySliderVal;

        Debug.Log(mass);

        //Change mass display
        GameObject.Find("GreenBallMassLabel").GetComponent<TMPro.TextMeshProUGUI>().text = "Green Ball Mass: " + System.Math.Round(mass,2) + " kg";

        //Change Ball mass
        GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().mass = mass;

        //change air resistance based on mass if air resistance is on
        if (GameObject.Find("AirResistanceToggle").GetComponent<Toggle>().isOn)
        {
            float mass = GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().mass;
            GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 2.5f / (mass);

            //cap drag at 1
            if (GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag >= 1)
            {
                GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 1;
            }

            GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().drag = 0.5f;
        }
    }

}
