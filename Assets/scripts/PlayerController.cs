using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionPartcle;
    public ParticleSystem dirtParticle;

    private float speed = 100;
    public GameObject playerObj;
    private float acceleration = 25;
    private float gravityModifier = 5;

    private bool onGround = true;
    public bool gameOver = false;

   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        

        // Saltar
            if (Input.GetKeyDown(KeyCode.Space) && onGround == true && gameOver != true) {

            playerRb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
            onGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle")) {

            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionPartcle.Play();
            dirtParticle.Stop();


        }
    }
}
