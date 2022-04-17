using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunButtonKinematics : MonoBehaviour
{
    public GameObject cannonBall;
    //public Transform firePoint;
	//public Vector2 initialV;
    public TextMeshProUGUI winText;
    public TMP_InputField hope;
    public TextMeshProUGUI invalidText;

    
    
    private void Fire()
    {
        //Vector2 initialV =
        float hope2 = float.Parse(hope.text);
        if (hope2 < 0 || hope2 > 13)
        {
            throw new ArgumentException();
        }
        Vector2 initialV = new Vector2(hope2 / Mathf.Sqrt(2), hope2 / Mathf.Sqrt(2));
        Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
		rb.AddForce(initialV, ForceMode2D.Impulse);
    }
	
    public void WhenPressed()
    {
        if (winText.text == "")
        {
            try
            {
                Fire();
                GameObject.Find("CanBall").GetComponent<Rigidbody2D>().gravityScale = 1;
                winText.text = "Launched!";
                winText.color = new Color(0, 0, 0, 255);
                invalidText.text = "";
            }
            catch (Exception e)
            {
                invalidText.text = "Input Valid Input (between 0-13)";
                //invalidText.color = new Color(0, 0, 0, 255);
            }
            
        }
        
        
    }
}
