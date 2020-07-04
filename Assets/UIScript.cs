using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public static bool isPaused=false;
    public GameObject pauseMenuUI;
    public GameObject deadUI;
    public Image healthBar;
    public float health=3;
    public Sprite OneLess;
    public Sprite TwoLess;
    public Sprite Deceased;
    private bool isDead=false;
    void Start(){
        Time.timeScale=1f;
    }
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
        if (Input.GetKeyDown(KeyCode.H)){
            health--;
        }
        if(health==2){
            healthBar.sprite=OneLess;
        }
        if(health==1){
            healthBar.sprite=TwoLess;
        }
        if(health==0){
            healthBar.sprite=Deceased;
            Die();
        }
    }
    public void Resume(){
        if(!isDead){
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        isPaused=false;
        }
    }
    public void Pause(){
        if(!isDead){
        pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        isPaused=true;
        }
    }
    public void Menu(){
        if(!isDead){
        SceneManager.LoadScene("MenuScene");
        Time.timeScale=1f;
        }
    }
     public void Die(){
         isDead=true;
         deadUI.SetActive(true);
         Time.timeScale=0f;
     }
     public void Restart(){
         isDead=false;
         deadUI.SetActive(false);
         SceneManager.LoadScene("SampleScene");
         Time.timeScale=1f;
     }


}
