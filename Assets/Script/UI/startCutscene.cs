using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public static bool isCutsceneOn;
    public Animator camAnim;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isCutsceneOn = true;
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutScene), 3f);
        }
    }
    
    void StopCutScene()
    {
        isCutsceneOn = false;
        camAnim.SetBool("cutscene1", false);
        Destroy(gameObject);
    }
}
