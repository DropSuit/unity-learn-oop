using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public float score;
    private bool isGrabbed;
    private float m_fallingSpeed = 1;
    private GameObject player;
    public float fallingSpeed
    {
        get {return m_fallingSpeed;}

        set {m_fallingSpeed = value;}
    }

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (!isGrabbed)
        {
            transform.Translate(Vector2.down * fallingSpeed * Time.deltaTime);
        }
        else if (isGrabbed)
        {
            transform.position = player.transform.position;
        }

        if (transform.position.y <= -9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isGrabbed = true;
        }

        if (other.CompareTag("Pentagram"))
        {
            other.GetComponent<Pentagram>().pentagramScore += score;
            Destroy(gameObject);
        }
    }
}
