using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFondoController : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicion = transform.position;

        Debug.Log(posicion);
     //   if (transform.position.x >= 46) { new Vector3(56f, 9.5f, 4); }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
         if (transform.position.x <= -80)
            {
                Destroy(this.gameObject);
            }

    }
}
