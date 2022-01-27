using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public NewBehaviourScript _player;

   
    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<NewBehaviourScript>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGrounded = true;
        _player._animator.SetBool("Jumping", false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }
}
