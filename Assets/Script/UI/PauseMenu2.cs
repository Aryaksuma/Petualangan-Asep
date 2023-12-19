using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu2 : MonoBehaviour
{
    public GameObject btnPause;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        btnPause.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseMenu.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            PauseGame();
        }
        else if(pauseMenu.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(false);
            ResumeGame();
        }
    }

    public void HomeButton(string scenename)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scenename);
    }

    public void PauseGame()
    {
        Debug.Log("Ditekan");
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        btnPause.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        btnPause.SetActive(true);

    }
}
