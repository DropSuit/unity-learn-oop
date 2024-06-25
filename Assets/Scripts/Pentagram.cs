using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pentagram : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] public float pentagramScore;
    [SerializeField] private float maxPentagramScore;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (pentagramScore >= maxPentagramScore)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }
}
