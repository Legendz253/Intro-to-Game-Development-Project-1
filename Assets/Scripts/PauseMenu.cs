using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();

        }
    }
    public void TogglePause()
    {
        if (isPaused == true)
        {
            //unpause
            Time.timeScale = 1;

            pauseUI.SetActive(false);
            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0;
            
            pauseUI.SetActive(true);
            isPaused = true;

        }
        
        //Changes the isPaused setting (true to false or vice versa) on occasion of pausing.
        //isPaused = !isPaused;
    }
    public void Quit()
    {
        Application.Quit();
    }

}
