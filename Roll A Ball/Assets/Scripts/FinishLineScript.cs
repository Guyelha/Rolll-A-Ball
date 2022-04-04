using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    public GameObject Player;
    public MovementScript movementScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<MovementScript>())
        {
            movementScript.enabled = false;
            Player.GetComponent<Rigidbody>().isKinematic = true;
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
