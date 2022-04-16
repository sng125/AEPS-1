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
        //GetComponent<Rigidbody>().mass = scale;
        //mass = GetComponent<Rigidbody>().mass;
    }

    public void ChangeMass()
    {
        Slider mySlider = GameObject.Find("GreenBallMassSlider").GetComponent<Slider>();
        float mySliderVal = mySlider.value * 100;
        mass = mySliderVal;

        Debug.Log(mass);

        //Change mass display
        GameObject.Find("GreenBallMassLabel").GetComponent<TMPro.TextMeshProUGUI>().text = "Green Ball Mass: " + System.Math.Round(mass,2) + " kg";

    }
    public void UpdateMassLabel()
    {
        SpriteRenderer renderer = GameObject.Find("Background").GetComponent<SpriteRenderer>();
        //renderer.sprite = 
    }
}
