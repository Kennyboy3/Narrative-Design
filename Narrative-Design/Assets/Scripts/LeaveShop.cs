using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveShop : MonoBehaviour
{
    private bool playerInRange;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.LoadScene(SceneTransitionManager.Instance.previousScene);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            player.transform.position = SceneTransitionManager.Instance.playerPosition;
        }
        SceneManager.sceneLoaded -= OnSceneLoaded;
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
