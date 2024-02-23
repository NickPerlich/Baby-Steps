using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManagerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogue;
    [SerializeField] GameObject endButton;
    [SerializeField] GameObject nextButton;
    private string[] endDialogue =
    {
        "Leah: This is so fun, Daddy!",
        "Leah: I'm so glad you can walk again!",
        "Kevin: I promised you, didn't I?",
        "Melanie: It's so good to see you moving again",
        "Kevin: I won't take it for granted."
    };
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.text = endDialogue[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClick()
    {
        if (index == endDialogue.Length-1)
        {
            nextButton.SetActive(false);
            endButton.SetActive(true);
        }
        else
        {
            
            dialogue.text = endDialogue[++index];
        }
    }

    public void endGame()
    {
        SceneManager.LoadScene("Title Scene");
    }
}
