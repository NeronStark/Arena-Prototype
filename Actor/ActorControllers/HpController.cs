using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*=============================================
Class controls operations with HP of gladiator
=============================================*/

public class HpController : MonoBehaviour
{
    public BattleUI battleUI;
    public ActorType _ActorType;

    public float maxHP;
    public float curHp;
    public bool isDead = false;


    public void Start()
    {
        _ActorType = transform.GetComponent<ActorType>();
    }
    public void HpMinus(float value)
    {
        if(curHp > 0)
        {
            if(curHp > value)
            {
                curHp = curHp - value;
            }
            else
            {
                isDead = true;
                //Make Collider of Enemy Movible by switch type IsTrigger to True
                transform.GetComponent<CapsuleCollider>().isTrigger = true;
                curHp = 0;
                //Send message Gladiator DEAD
                print(transform.name + "is dead");
                transform.GetComponent<Animation>().Play("die");
                
            }
        }
    }

    public void HpPlus(float value)
    {
        if(curHp > 0)
        {
            if(curHp + value <= maxHP )
            {
                curHp = curHp + value;
            }
            else if (curHp + value > maxHP)
            {
                curHp = maxHP;
            }
        }
    }

    public void FixedUpdate()
    {
        //Try to figure out is Actor Player or Enemy to call correct function to HUD
        if(_ActorType.isPlayer)
        {
            battleUI.HpHUD(curHp * 0.01f);
        }
        else
        {
            battleUI.HpHudEnemy(curHp * 0.01f);
        }
        
    }
}
