using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 10f;
    //[SerializeField] private float maxJumpTime = 0.3f;

    [Header("Ground Check")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float groundDistance = 0.25f;

    [Header("Sprites")]
    [SerializeField] private Sprite slideSprite;     // ground sprite
    [SerializeField] private Sprite preSlideSprite;  // jump sprite
    [SerializeField] private AudioSource jumpAudio;  // Jump Audio


    private SpriteRenderer sr;

    private bool isGrounded;
    //private bool isJumping;
    //private float jumpTimer;

    private void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        sr.sprite = slideSprite;    // default on ground
    }

    private void Update()
    {
        CheckGrounded();

        // Keyboard jump
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        UpdateSprite();
    }

    private void CheckGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);
    }

    private void UpdateSprite()
    {
        if (isGrounded)
            sr.sprite = slideSprite;
        else
            sr.sprite = preSlideSprite;
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        if (jumpAudio != null)
            jumpAudio.Play();

        sr.sprite = preSlideSprite;
    }

    // Arduino uses this
    public void ForceJump()
    {
        if (isGrounded)
            Jump();
    }
}
