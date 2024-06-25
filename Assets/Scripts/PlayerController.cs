using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class PlayerController : MonoBehaviour
{

    // ENCAPSULATION
    private float m_Speed = 5;
    private float baseSpeed;
    public float speed
    {
        get {return m_Speed;}
        set {m_Speed = value;}
    }
    [SerializeField] private SpriteRenderer wizardSprites;
    [SerializeField] public bool powerUpSpeed;
    private float powerUpSpeedTime = 10;
    private Rigidbody2D playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        baseSpeed = m_Speed;
    }


    // ABSTRACTION
    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float xVelocity = horizontalInput * Time.deltaTime;

        if (horizontalInput > 0)
        {
            wizardSprites.flipX = true;
        }else if (horizontalInput < 0)
        {
            wizardSprites.flipX = false;
        }

        playerRb.velocity = new Vector2(xVelocity, 0).normalized * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

    }

    IEnumerator MovementPowerUp()
    {
        yield return new WaitForSeconds(powerUpSpeedTime);
        m_Speed = baseSpeed;
    }

    private void Update()
    {
        Movement();
    }
}
