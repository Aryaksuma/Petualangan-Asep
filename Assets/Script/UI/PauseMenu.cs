using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject level1Menu;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        level1Menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HomeButton(string scenename)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scenename);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        level1Menu.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        level1Menu.SetActive(true);

    }
}
