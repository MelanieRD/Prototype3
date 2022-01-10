using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    
    private float speed = 100;
    public GameObject playerObj;
    private float acceleration = 25;
    private float gravityModifier = 5;

    private bool onGround = true;
    public bool gameOver = false;

   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Avanzar
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            playerObj.transform.position = Vector3.right * Time.deltaTime* speed;
        }
        

        // Saltar
            if (Input.GetKeyDown(KeyCode.Space) && onGround == true) {

            playerRb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
            onGround = false;
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle")) {

            gameOver = true;
            Debug.Log("Game Over");
        
        }
    }
}
