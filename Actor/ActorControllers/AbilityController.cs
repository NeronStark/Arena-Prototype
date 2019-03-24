using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*=============================================
Class controls operations with Stamina of gladiator
=============================================*/


public class AbilityController : MonoBehaviour
{
    public BattleUI _BattleUI;
    public ActorType _ActorType;
    public float maxStamina;
    public float curStamina;

    public float staminaRestoreRate = 2.2f;
    

    
    public void AttackPlay()
    {
        _ActorType.actorAnimation.Play("attack");
    }

    public void SaminaMinus(float value)
    {
      if(curStamina > value)
      {
        if(curStamina - value > 0)
            {
                curStamina = curStamina - value;
                _BattleUI.StaminaHUD(value * 0.01f);
            }
      }
      
    }

    public void Update()
    {
        if(_ActorType.isPlayer)
        {
            _BattleUI.StaminaHUD(curStamina * 0.01f);
            if (curStamina < maxStamina)
            {
                curStamina += staminaRestoreRate * Time.deltaTime;

            }
        }
        
    }


}
