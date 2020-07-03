using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool isPaused=false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            if(isPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        isPaused=false;

    }
    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        isPaused=true;
    }
    public void Menu(){
        SceneManager.LoadScene("MenuScene");
        Time.timeScale=1f;
    }
}
