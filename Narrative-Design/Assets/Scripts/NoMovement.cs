using UnityEngine;
using Yarn.Unity;

public class NoMovement : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public DialogueRunner dialogueRunner;

    void Start()
    {
        if (playerMovement == null || dialogueRunner == null)
        {
            Debug.LogError("PlayerMovement or DialogueRunner not assigned!");
            return;
        }

        dialogueRunner.onDialogueStart.AddListener(OnDialogueStart);
        dialogueRunner.onDialogueComplete.AddListener(OnDialogueComplete);
    }

    private void OnDialogueStart()
    {
        playerMovement.enabled = false;
    }

    private void OnDialogueComplete()
    {
        playerMovement.enabled = true;
    }
}