using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Vector2 moveDirection;

    public float moveSpeed = 2f;

    Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveDirection);

        


        if (moveDirection.magnitude == 0)
        {
            anim.SetBool("isWalking", false); 
        }

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    public void Move(Vector2 direction)
    {
       

        transform.Translate(direction.x * moveSpeed * Time.deltaTime, 0, direction.y * moveSpeed * Time.deltaTime);


        anim.SetBool("isWalking", true);
    }

}
