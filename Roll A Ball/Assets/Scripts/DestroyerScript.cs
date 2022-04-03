using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<TrapMovementScript>())
        {
            Destroy(other.gameObject);
            print("Trap destroyed");
        }
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            print("enemy destroyed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
