using System;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]

public class Enemy : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        System.Random random = new System.Random();
        int negative = 0;
        int positive = 1;

        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.flipX = Convert.ToBoolean(random.Next(negative, ++positive));
    }
}
