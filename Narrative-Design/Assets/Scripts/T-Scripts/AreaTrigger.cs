using UnityEngine;
using UnityEngine.UI;

public class AreaTrigger : MonoBehaviour
{
    public Text displayText;

    void Start()
    {
        Debug.Log("AreaTrigger");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Kiểm tra nếu đối tượng có tag là "Player"
        {
            displayText.text = "Entrance area - by Thai Tai";
            displayText.gameObject.SetActive(true);  // Hiển thị Text
        }
    }

    // Sự kiện khi đối tượng rời khỏi khu vực trigger
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Kiểm tra nếu đối tượng có tag là "Player"
        {
            Debug.Log("Player exited the area");
            displayText.gameObject.SetActive(false);  // Ẩn Text
        }
    }
}
