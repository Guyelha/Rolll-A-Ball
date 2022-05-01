using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    
    public bool lostGame = false;
    public GameObject LostCanvas;
    public GameObject WinningCanvas;
    public bool wonGame = false;
    
    
    

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

    public void WonGame()
    {
        if(!wonGame)
        {
            wonGame = true;
            WinningCanvas.SetActive(true);
            Invoke("LoadNextLevel", 1);
        }
    }
    public void LoadNextLevel()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    

 
}
