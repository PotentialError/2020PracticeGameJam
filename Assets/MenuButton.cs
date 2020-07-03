using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void StartGame(){
        Debug.Log("Schman WTF");
        SceneManager.LoadScene("SampleScene");
        
    }
}
