using UnityEngine;
using Yarn.Unity;

public class RatsArea : MonoBehaviour
{
    public string startNode = "RatsDiplomacy"; // Nút hội thoại khi tiếp cận khu vực chuột
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
            dialogueRunner.StartDialogue(startNode);
        }
    }
}
