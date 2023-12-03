using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject ButtonSetting;
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        ButtonSetting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void VolumeButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        menupanel.SetActive(false);
        ButtonSetting.SetActive(true);
    }

    public void BackButton()
    {
        ButtonSetting.SetActive(false);
        menupanel.SetActive(true);
    }

    public void ButtonQuit()
    {
        Application.Quit();
        Debug.Log("EXIT..");
    }
}
