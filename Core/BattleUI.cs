using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour
{
    public Button headAttack;

    public Image staminaBar;
    public Image hpBar;

    public Image staminaEnemy;
    public Image hpEnemy;

    public void StaminaHUD(float reduce)
    {
        staminaBar.fillAmount = reduce;
    }
    
    public void HpHUD(float reduce)
    {
        hpBar.fillAmount = reduce;
    }

    public void StaminaHudEnemy(float reduce)
    {
        staminaEnemy.fillAmount = reduce;
    }

    public void HpHudEnemy(float reduce)
    {
        hpEnemy.fillAmount = reduce;
    }
}
