using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TMPManager : MonoBehaviour
{
    [SerializeField] GameObject background;
    [SerializeField] Sprite[] sprites;
    [SerializeField] TextMeshProUGUI dialogue;
    private string[] hospitalDialogue = {
        "Doctor: You're a hero, sir",
        "Doctor: You saved a lot of lives",
        "Doctor: The worst injury was a second degree burn",
        "Doctor: Unfortunately...",
        "Doctor: This came at great cost to your health",
        "Doctor: You're lucky to be alive",
        "Doctor: We managed to repair a lot of damage",
        "Doctor: With physical therapy you'll walk again",
        "Doctor: It won't be easy",
        "Doctor: But you are incredibly strong",
        "Doctor: I know you can do it",
        "Leah: Daddy, will you still teach me to ice skate?",
        "Kevin: Of course, baby",
        "Kevin: I'll be back on my feet in no time",
        "Melany: Oh God Kevin, we were so scared",
        "Kevin: I'm sorry. I love you both so much",
        "Kevin: I'm gonna work really hard for you two",
        "Melany: I love you so much",
        "Kevin: I love you, too"
    };
    private string[] ptDialogue =
    {
        "PT: You're doing great, sir!",
        "Kevin: This...is...exhausting"
    };
    private string[] missionDialogue =
    {
        "General: Nate!",
        "General: You are one of our finest neurotransmitters",
        "General: The human is relearning how to walk",
        "General: We've started reopening the pathway",
        "General: Few have made it to the legs",
        "General: We lost a lot of good soldiers",
        "General: Get to the legs Nate",
        "General: But, if you don't",
        "General: We'll just send the next guy",
        "Nate: You got it, dude",
        "General: How many times have I told you",
        "General: Say, 'Yes, General!'",
        "Nate: Hahaha. You're crazy, old man",
        "Nate: Catcha on the flip, dude"
    };
    private string[][] story;
    private int row = 0;
    private int col = 0;
    private SpriteRenderer backgroundSprite;

    // Start is called before the first frame update
    void Start()
    {
        story = new string[][] { hospitalDialogue, ptDialogue, missionDialogue };
        dialogue.text = hospitalDialogue[col];
        backgroundSprite = background.GetComponentInChildren<SpriteRenderer>();
        backgroundSprite.sprite = sprites[row];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClick()
    {
        if (col == story[row].Length-1)
        {
            if (row == story.Length-1)
            {
                SceneManager.LoadScene("Game Scene");
            }
            else
            {
                row++;
                col = 0;
                dialogue.text = story[row][col];
                backgroundSprite.sprite = sprites[row];
            }
        }
        else
        {
            col++;
            dialogue.text = story[row][col];
        }
    }

}
