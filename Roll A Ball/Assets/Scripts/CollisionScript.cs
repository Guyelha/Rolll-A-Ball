using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public MovementScript movementScript;
    public GameObject LostCanvas;
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.transform.tag=="Enemy")
        {
            movementScript.enabled = false;
            gameManager.LostGame();
            
            
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
