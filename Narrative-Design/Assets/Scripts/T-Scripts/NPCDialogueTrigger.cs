using UnityEngine;
using Yarn.Unity;

public class NPCDialogueTrigger : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public string dialogueNode = "BatConversation";
    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E) && !dialogueRunner.IsDialogueRunning)
        {
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        if (dialogueRunner != null)
        {
            dialogueRunner.StartDialogue(dialogueNode);
            DisablePlayerMovement();
        }
    }

    private void DisablePlayerMovement()
    {
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }

    private void EnablePlayerMovement()
    {
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Enter ");
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Exit ");
            isPlayerInRange = false;
        }
    }

    private void OnEnable()
    {
        dialogueRunner.onDialogueComplete.AddListener(OnDialogueComplete);
    }

    private void OnDisable()
    {
        dialogueRunner.onDialogueComplete.RemoveListener(OnDialogueComplete);
    }

    private void OnDialogueComplete()
    {
        EnablePlayerMovement();
    }
}
