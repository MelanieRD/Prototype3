using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacle : MonoBehaviour
{

    public GameObject obstacle_obj;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();

        InvokeRepeating("spawn",1f, Random.Range(1f,5f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void spawn() {
        if (playerControllerScript.gameOver == false) {
            Instantiate(obstacle_obj, new Vector3(28, 0, 0), obstacle_obj.transform.rotation);
        }
        }
}
