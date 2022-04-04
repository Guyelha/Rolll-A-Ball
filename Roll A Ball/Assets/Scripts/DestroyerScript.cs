using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public float forwardSpeed = 200;
   
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() // using addforce to make connection between forwardspeed variable and the rigidbody component.
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
    
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<TrapMovementScript>())
        {
            Destroy(other.gameObject);
           
        }
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
