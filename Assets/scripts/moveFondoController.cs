using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFondoController : MonoBehaviour
{

    public float speed;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
         if (transform.position.x <= -80)
            {
                Destroy(this.gameObject);
            }

    }
}
