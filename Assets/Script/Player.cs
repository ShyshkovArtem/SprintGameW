using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] SoundEffectManager soundEffectManager;

    private void Awake()
    {
        soundEffectManager = FindObjectOfType<SoundEffectManager>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }

        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadSceneAsync(0);
            }
            else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            soundEffectManager.PlayLevelComplete();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
        }
        if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            
            foreach (ButtonActivate button in FindObjectsOfType<ButtonActivate>())
            {
                
                button.canPush = false;
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (ButtonActivate button in FindObjectsOfType<ButtonActivate>())
            {
                button.canPush = true;
            }
        }
    }
}
