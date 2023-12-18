using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Collasion)
    {
        if (Collasion.CompareTag("Player"))
        {
            sceneChanger("Level2");
        }
    }
    public void sceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
