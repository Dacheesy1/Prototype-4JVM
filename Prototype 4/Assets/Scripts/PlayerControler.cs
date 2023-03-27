using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public bool hasPowerup = false;
    private float powerupStrength = 500.0f;
    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
        private void OnTriggerEnter(Collider other)
    {
    if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
     }

     IEnemerater PowerupCountdownRoutine()
     {
yeild return new WaitForSeconds(7);

     }

     private void OnCollisionEnter(Collision collision)
     {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)

    {
        Rigidbody EnemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

        EnemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        Debug.Log("Collided with: " + collision.gameObject.name + " with Powerup set to " + hasPowerup);
    }
     }
}
