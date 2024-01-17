using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();
    }

    public void searchDialog()
    {
        if (clue == 0)
        {
            dialog = "OH DEAR! I've lost my film for my camera! Can you FIND " + collectibles[clue];
        }
        if (clue == 1)
        {
            dialog = "OH! I've lost my baloons for my party! Can you FIND " + collectibles[clue];
        }
        if (clue == 2)
        {
            dialog = "OH MY GOD! THAT MAN IS DROWNING! Can you FIND THE " + collectibles[clue];
        }
        if (clue == 3)
        {
            dialog = "OH WOW! I've seem to have lost my Bull's Eye Can you FIND " + collectibles[clue];
        }
        if (clue == 4)
        {
            dialog = "I NEED a pipe to stop this leak! Find the " + collectibles[clue];
        }
        if (clue == 5)
        {
            dialog = "Excuse me? Can you find a " + collectibles[clue];
        }
        if (clue == 6)
        {
            dialog = "H-hey, I need food a cat took my food. Please find my " + collectibles[clue];
        }
        if (clue == 7)
        {
            dialog = "HI MY BIRDS NEED HOME. FIND A " + collectibles[clue];
        }
        if (clue == 8)
        {
            dialog = "Hooooooooooonk! Find " + collectibles[clue];
        }
        if (clue == 9)
        {
            dialog = "Magik hat! please find a " + collectibles[clue];
        }
        //dialog = "Hi! Can YOU help me FIND my " + collectibles[clue] + "?";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You FOUND my " + collectibles[clue] + "! YIPPIE!";
            end = true;
        }
        else
        {
            dialog = "NO, that's NOT my " + collectibles[clue] + ".";
        }
    }

    private void specficDialog()
    {
        

    }
    public void coinsScattered()
    {
        begin = false;
    }

}
