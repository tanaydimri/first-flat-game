using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D characterController;
    public float runSpeed = 40f;
    private float horizontalMove = 0.0f;
    private float verticalMove = 0.0f;
    private bool jump = false;
    private bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        // This gives a normalised direction based on the keys.
        // Right or D = 1
        // Left or A = -1
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("PlayerSpeed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch")) {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        // Move our Character
        characterController.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
}
