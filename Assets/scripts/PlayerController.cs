using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float speed = 10;
    public GameObject playerObj;
    public float acceleration = 10f;
    public float gravityModifier;

    private bool onGround = true;

   
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
        onGround = true;
    }
}
