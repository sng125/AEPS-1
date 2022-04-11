using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButtonKinematics : MonoBehaviour
{
    public GameObject cannonBall;
    public Transform firePoint;
	public Vector2 initialV;

    
    
    private void Fire()
    {
        //Vector2 initialV =
        Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
		rb.AddForce(initialV, ForceMode2D.Impulse);
    }
	
    public void WhenPressed()
    {
        Physics2D.gravity = new Vector2(0, -10);
        //string 
		Fire();
    }
}
