using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    //Button Functions
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadGravityLevel()
    {
        SceneManager.LoadScene("GravityLevel");
    }

    public void LoadKinematicsLevel()
    {
        SceneManager.LoadScene("KinematicsLevel");
    }

    public void LoadFrictionLevel()
    {
        SceneManager.LoadScene("FrictionLevel");
    }
}
