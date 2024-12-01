using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                isPaused = true;
                Pause();
            }
            else
            {
                isPaused = false;
                UnPause();
            }
        } 
    }


    public void Pause()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
