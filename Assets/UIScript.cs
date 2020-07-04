using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text livesText;
    public static float livesNum=3;
    public static bool isRestart=false;
    
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
        isRestart=false;
        Time.timeScale=1f;
        livesText.text="X"+livesNum;
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
            if(livesNum==0){
            Die();
            }
            else if(!isRestart){
                LivesLost();
            }
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
         isRestart=true;
         isDead=false;
         deadUI.SetActive(false);
         SceneManager.LoadScene("MenuScene");
         Time.timeScale=1f;
         livesNum=3;
     }
     public void LivesLost(){
         livesNum--;
         SceneManager.LoadScene("SampleScene");
         livesText.text="X"+livesNum;
     }


}
