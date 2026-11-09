using UnityEngine;

public class ScoringZoneDetector : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }
        }
    }
}