using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoController : MonoBehaviour
{

    public GameObject fondoPrefab;
    private Vector3 spawnInicio = new Vector3(100, 9.5f, 4 );

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 5.8f, 10.57f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn() { 
    
        Instantiate(fondoPrefab, spawnInicio, fondoPrefab.transform.rotation);
    }

}
