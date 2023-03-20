using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 3.0f;
    private Rigidbody EnemyRb;
    private GameObject Jorb;
    // Start is called before the first frame update
    void Start()
    {
       EnemyRb = GetComponent<Rigidbody>();
       player = GameObject.Find("Jorb"); 
    }

    // Update is called once per frame
    void Update()
    {
        EnemyRb.AddForce((Jorb.transform.position))
        
    }
}
