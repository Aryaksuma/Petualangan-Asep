using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject peluru;

    public Transform pointTembak;

    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("shoot");
            GameObject peluruS = Instantiate(peluru, pointTembak.position, pointTembak.rotation);
            peluruS.GetComponent<Rigidbody2D>().velocity = transform.right * 6;
            Destroy(peluruS, 20000f);
        }
    }
}
