using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{

    public void LoadScene()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
