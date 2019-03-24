using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorType : MonoBehaviour
{
    string _name;
    int type;
    int _class;
    float power;
    float speed;
    float hp;
    float defence;
    float expirience;
    float stamina;
    public bool isPlayer = true;


    public Animation actorAnimation;


    private void Start()
    {
        actorAnimation = transform.GetComponent<Animation>();
        
    }



}
