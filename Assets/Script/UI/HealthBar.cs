using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    private float MaxHealth;

    public void SetMaxHealth(int health)
    {
        /*slider.maxValue = health;*/
        MaxHealth = health;
        slider.value = 1;
    }
    
    public void SetHealth(int health)
    {
        Debug.Log("SetHealth");
        float Current = health;
        float value = Current / MaxHealth;
        Debug.Log("Health" + value);
        slider.value = value;
    }
}
