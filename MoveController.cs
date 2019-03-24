using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    public ActorType _ActorType;
    public StateController _StateController;
    public GameObject actor;
    public GameObject targetForward;
    public FixedJoystick _Joystick;


    public float speed = 1f;
    

    private void Start()
    {
        actor = transform.gameObject;
    }
    private void Update()
    {
        
        actor.transform.LookAt(targetForward.transform);
        actor.transform.position = new Vector3(actor.transform.position.x,0.05f, actor.transform.position.z);

        if (_StateController.curState != StateController.State.skill)
        {
            if (Input.GetKey(KeyCode.W))
            {
                _ActorType.actorAnimation.Play("walk");
                actor.transform.position = new Vector3(actor.transform.position.x, actor.transform.position.y, actor.transform.position.z + speed * Time.deltaTime);
                _StateController.ChangeState(StateController.State.move);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _ActorType.actorAnimation.Play("walk");
                actor.transform.position = new Vector3(actor.transform.position.x, actor.transform.position.y, actor.transform.position.z - speed * Time.deltaTime);
                _StateController.ChangeState(StateController.State.move);
            }
            if (Input.GetKey(KeyCode.A))
            {
                _ActorType.actorAnimation.Play("walk");
                actor.transform.position = new Vector3(actor.transform.position.x - speed * Time.deltaTime, actor.transform.position.y, actor.transform.position.z);
                _StateController.ChangeState(StateController.State.move);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _ActorType.actorAnimation.Play("walk");
                actor.transform.position = new Vector3(actor.transform.position.x + speed * Time.deltaTime, actor.transform.position.y, actor.transform.position.z);
                _StateController.ChangeState(StateController.State.move);
            }

            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                if (!_ActorType.actorAnimation.IsPlaying("attack"))
                {   
                    _ActorType.actorAnimation.Play("idlebattle");
                    _StateController.ChangeState(StateController.State.idle);
                }

            }

            
            Vector3 direction = Vector3.forward * _Joystick.Vertical + Vector3.right * _Joystick.Horizontal;
            Vector3 movePos = transform.position + direction;
            
            if (direction != new Vector3(0, 0, 0))
            {
                _ActorType.actorAnimation.Play("walk");
                transform.position = Vector3.MoveTowards(transform.position, movePos, speed * Time.deltaTime);
                
            }
            
            
            

        }
           
    }   


}
