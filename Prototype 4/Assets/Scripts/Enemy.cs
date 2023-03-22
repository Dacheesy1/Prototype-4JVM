using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 3.0f;
    private Rigidbody EnemyRb;
    private GameObject Jorb;
    //Jorb is the player :)
    // Start is called before the first frame update
    void Start()
    {
       EnemyRb = GetComponent<Rigidbody>();
       Jorb = GameObject.Find("Jorb"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (Jorb.transform.position - transform.position).normalized;

        EnemyRb.AddForce(lookDirection * speed);
        
    }
}
