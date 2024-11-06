using UnityEngine;
using Yarn.Unity;

public class FarmerTalk : MonoBehaviour
{
    private bool playerInRange;
    public DialogueRunner dialogueRunner;
    public string startNode = "StartFarmer";

    // Reference to the player and their movement script
    public GameObject player;
    private PlayerMovement playerMovement;

    void Start()
    {
        // Ensure playerMovement is assigned
        if (player != null)
        {
            playerMovement = player.GetComponent<PlayerMovement>();
        }
    }

    void Update()
    {
        // Check if the player is in range and has pressed the E key
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // If the dialogue is not running, start the dialogue
            if (!dialogueRunner.IsDialogueRunning)
            {
                dialogueRunner.StartDialogue(startNode);
            }
        }

        // Disable player movement if the dialogue is running, otherwise enable it
        if (playerMovement != null)
        {
            playerMovement.enabled = !dialogueRunner.IsDialogueRunning;
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
