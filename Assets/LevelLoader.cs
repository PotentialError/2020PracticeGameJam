using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextLevel(int level)
    {
        StartCoroutine(LoadLevel(level));
    }
    IEnumerator LoadLevel(int level)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(level);
    }
}
