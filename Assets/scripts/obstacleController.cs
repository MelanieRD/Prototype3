using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour
{
   private int speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x <= -7) { Destroy(this.gameObject); }
        
    }
}
