using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5;
    public float jumpforce = 10;

    public bool isGrounded;

    float dix;

    public SpriteRenderer renderer;

    public Animator _animator;
    Rigidbody2D rBody;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        dix = Input.GetAxisRaw("Horizontal");

        Debug.Log(dix);
     

        transform.position += new Vector3(dix, 0, 0) * speed *Time.deltaTime;


        if(dix == -1)
        {
            renderer.flipX = true;
            _animator.SetBool("Running", true);
        }
        else if(dix == 1)
        {
            renderer.flipX = false;
            _animator.SetBool("Running", true);
        }
        else 
        {
            _animator.SetBool("Running", false);
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            _animator.SetBool("Jumping", true);
        }
    }   
}
