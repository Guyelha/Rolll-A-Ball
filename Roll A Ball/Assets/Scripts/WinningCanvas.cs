using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextLevel", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      

    }

    public void NextLevel()
    {
     
    }
}
