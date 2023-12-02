using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public Image playerHpBar;

    public void PlayerBar(float hp)
    {
        playerHpBar.fillAmount = hp / 100;
    }
}
