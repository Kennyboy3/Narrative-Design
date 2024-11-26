using UnityEngine;

public class HiddenRouteMarker : MonoBehaviour
{
    public static int markersVisited = 0; // Số điểm đã đến
    private bool isVisited = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isVisited)
        {
            isVisited = true;
            markersVisited++;
            Debug.Log("Marker reached! Total markers: " + markersVisited);
        }
    }
}
