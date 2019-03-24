using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseAttackHead : MonoBehaviour
{
    public AbilityController _AbilityController;
    public HpController _HpController;
    public MoveController _MoveController;
    public StateController _StateController;

    public float staminaCost = 15;
    public float rangeOfAttack = 0.5f;
    public float damage = 10;

    public float reload = 0;
    public float reloadTime = 1;
    public float stateSkillTime = 1;
    public float stateSkillReloadTime = 1;

    public void BaseHeadAttack()
    {
        
        if (_AbilityController.curStamina >= staminaCost)
        {
            if (reload <= 0)
            {
                _StateController.ChangeState(StateController.State.skill);
                stateSkillTime = stateSkillReloadTime;
                reload = reloadTime;
                
                //AnimationStart
                _AbilityController.AttackPlay();
                _AbilityController.SaminaMinus(staminaCost);

                if (Vector3.Distance(transform.position, _MoveController.targetForward.transform.position) < rangeOfAttack)
                {
                    _HpController.HpMinus(damage);
                }
                else
                {
                    print("ToFarFromTarget");   
                }
            }
        }
        else
        {
            print("Have not Stamina");
        }
    }
    public void Update()
    {
        if (reload > 0)
        {
            reload -= Time.deltaTime;

        }
        
        if(stateSkillTime > 0)
        {
            stateSkillTime -= Time.deltaTime;
        }
        else
        {
            _StateController.curState = StateController.State.idle;
        }

    }
}
