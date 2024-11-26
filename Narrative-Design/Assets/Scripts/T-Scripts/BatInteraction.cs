using UnityEngine;
using Yarn.Unity;

public class BatInteraction : MonoBehaviour
{
    public string startNode = "MeetBat"; // Nút bắt đầu hội thoại
    private DialogueRunner dialogueRunner;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueRunner.Stop();
            dialogueRunner.StartDialogue(startNode); // Bắt đầu hội thoại khi người chơi chạm
        }
    }
}
