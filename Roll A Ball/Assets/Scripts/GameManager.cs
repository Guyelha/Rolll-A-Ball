using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    
    public bool lostGame = false;
    public GameObject LostCanvas;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LostGame()
    {
        if(!lostGame)
        {
            lostGame = true;
            LostCanvas.SetActive(true);

        }
    }

    

 
}
