using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SinglePlayer()
    {
        SceneManager.LoadScene("Single");
    }

    public void MultiPlayer()
    {
        SceneManager.LoadScene("Multi");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
