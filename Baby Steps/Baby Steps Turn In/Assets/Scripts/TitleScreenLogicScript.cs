using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("Story Scene");
    }

    public void showCredits()
    {
        SceneManager.LoadScene("Credits Scene");
    }

    public void showControls()
    {
        SceneManager.LoadScene("Controls Scene");
    }
}
