using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoController : MonoBehaviour
{

    public GameObject fondoPrefab;
    public Vector3 spawnInicio = new Vector3(34, 9, 4 );

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1f, 10.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn() { 
    
        Instantiate(fondoPrefab, spawnInicio, fondoPrefab.transform.rotation);
    }

}
