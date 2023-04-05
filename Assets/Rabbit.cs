using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    public GameManagerScript logic;
    public bool birdIsAlive = true;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameManagerScript>();
        InvokeRepeating(nameof(AnimateSprite),0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && birdIsAlive) 
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void AnimateSprite()
    {
        spriteIndex++;
        if ( spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive=false;
    }
}
