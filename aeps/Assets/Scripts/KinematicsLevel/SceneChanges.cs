using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("LevelSelectMenu");
    }

    public void Reset()
    {
        SceneManager.LoadScene("KinematicsLevel");
    }
}
