using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{

    public GameObject actor;
    public enum State
    {
        skill,
        move,
        idle,
        down,
    }
    public State curState;

    public void ChangeState(State state)
    {
        curState = state;
    }

    public void Start()
    {
        actor = transform.gameObject;
    }
    public void Update()
    {
        if(curState == State.move)
        {
            print("Moving");
        }
        else if(curState == State.idle)
        {
            print("Idle");
        }
        else if(curState == State.down)
        {
            print("Down");
        }
        else if (curState == State.skill)
        {
            print("Use skill");           
        }
    }

}
