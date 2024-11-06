using UnityEngine;
using Yarn.Unity;

public class ShopkeeperTalk : MonoBehaviour
{
    private bool playerInRange;
    public DialogueRunner dialogueRunner;
    public string startNode = "StartShop";

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogueRunner.IsDialogueRunning == false) 
            { 
                dialogueRunner.StartDialogue(startNode); 
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
