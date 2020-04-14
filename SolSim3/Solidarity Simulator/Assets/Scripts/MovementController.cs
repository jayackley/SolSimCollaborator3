using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpVelocity = 10f;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRenderer;
    public GameObject playerObject;
    public bool diagonal;
    public AudioClip jump;
    public AudioClip steps;
    AudioSource sound;
    public float Volume;
    public bool footSteps;
    public bool flipped;
    public bool canPoke;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        sound = GetComponent<AudioSource>();
        canPoke = true;
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && GetComponent<Rigidbody2D>().velocity.y <= 0.0001 && GetComponent<Rigidbody2D>().velocity.y >= -0.0001)
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            GetComponent<Animator>().SetBool("ispoking", false);
            GetComponent<Animator>().SetBool("isjumping", true);
            sound.PlayOneShot(jump, Volume);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", true);
            footSteps = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", true);
            footSteps = true;
        }

        else if (GetComponent<Rigidbody2D>().velocity.y <= -0.0001)
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", false);
            footSteps = false;
            GetComponent<Animator>().SetBool("isjumping", false);
            GetComponent<Animator>().SetBool("isfalling", true);
        }

        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            GetComponent<Animator>().SetBool("iswalking", false);
            GetComponent<Animator>().SetBool("isjumping", false);
            GetComponent<Animator>().SetBool("isfalling", false);
            footSteps = false;
        }


        bool flipSprite = (spriteRenderer.flipX ? (rigidbody2d.velocity.x < 0.0f) : (rigidbody2d.velocity.x > 0.0f));

        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (footSteps == true && sound.isPlaying == false)
        {
            sound.loop = true;
            sound.Play();
        }
        if (footSteps == false && sound.isPlaying == false)
        {
            sound.loop = false;
            sound.Stop();
        }
        else
        {
            sound.loop = false;
        }

        if (spriteRenderer.flipX == true)
        {
            flipped = true;
            playerObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.86f, 0.13f);
        }
        else if (spriteRenderer.flipX == false)
        {
            flipped = false;
            playerObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.86f, 0.13f);
        }

    }

    private void OnGUI()
    {
        if (canPoke == true && Event.current.Equals(Event.KeyboardEvent("return")) && GetComponent<Rigidbody2D>().velocity.y <= 0.0001 && GetComponent<Rigidbody2D>().velocity.y >= -0.0001 && GetComponent<Rigidbody2D>().velocity.x <= 0.0001 && GetComponent<Rigidbody2D>().velocity.x >= -0.0001)
        {
            GetComponent<Animator>().SetBool("ispoking", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diagonal")
        {
            diagonal = true;
            playerObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 30);
            footSteps = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diagonal")
        {
            diagonal = true;
            playerObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void TurnOffPoking(AnimationEvent animation) 
    {
        GetComponent<Animator>().SetBool("ispoking", false);
    }

    public void Poke()
    {
        GameObject.Find("WaterCooler").GetComponent<InteractableManager>().Pour();
        GameObject.Find("Button").GetComponent<InteractableManager>().Pour();
        GameObject.Find("WaterCooler").GetComponent<InteractableManager>().primed = false;
        GameObject.Find("Button").GetComponent<InteractableManager>().primed = false;
    }
}

