using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    [SerializeField]
    private string targetScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //pindah scene
            LoadScene();
        }
    }


    private void LoadScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
