using UnityEngine;

public class interaction : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public float detectionRange = 5f; // Range within which the object becomes visible

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = false; // Make the object invisible at the start
        }
    }

    private void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if (distance <= detectionRange)
        {
            spriteRenderer.enabled = true; // Make the object visible
        }
        else
        {
            spriteRenderer.enabled = false; // Make the object invisible
        }
    }
}