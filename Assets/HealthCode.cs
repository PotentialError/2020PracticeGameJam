using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthCode : MonoBehaviour
{
    public Image healthBar;
    public float health=3;
    public Sprite OneLess;
    public Sprite TwoLess;
    public Sprite Deceased;
    

    void Update()
    {
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
            Time.timeScale=0f;
        }
    }
}
