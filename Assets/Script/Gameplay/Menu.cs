using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject ButtonSetting;
    public GameObject Credit1;
    public GameObject ControlSetting;
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

    public void CreditButton(string scenename)
    {
        ButtonSetting.SetActive(false);
        Credit1.SetActive(true);
    }

    public void ControlButton(string scenename)
    {
        ButtonSetting.SetActive(false);
        ControlSetting.SetActive(true);
    }
}
