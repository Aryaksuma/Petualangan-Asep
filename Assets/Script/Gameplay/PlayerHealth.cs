using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public float PlayerHp;
    public PlayerHp playerHp;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Level1");
            Destroy(this.gameObject);
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("level2");
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Damage");
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wolf")
        {
            PlayerHp -= 20;
            playerHp.PlayerBar(PlayerHp);
        }
        else if (other.gameObject.tag == "Boss")
        {
            PlayerHp -= 30;
            playerHp.PlayerBar(PlayerHp);
        }
    }
}
