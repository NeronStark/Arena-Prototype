using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{

    public GameObject player;
    public HpController _HpController;

    void Update()
    {
        if (!_HpController.isDead)
        {
            transform.LookAt(player.transform);
        }
        transform.position = new Vector3(transform.position.x, 0.05f, transform.position.z);
    }
}
