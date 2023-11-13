using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    public void Help()
    {
        SceneManager.LoadSceneAsync("Help");
    }
}
