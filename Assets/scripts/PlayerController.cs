using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float acceleration = 10f;
    public float speed = 10f;
    public GameObject playerObj;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
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
            if (Input.GetKeyDown(KeyCode.Space)) {

            playerRb.AddForce(Vector3.up * acceleration, ForceMode.Impulse);
        } 
    }
}
