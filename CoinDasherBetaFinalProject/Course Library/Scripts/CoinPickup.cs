using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int scoreValue = 1; // Score value for this coin

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player picked up the coin
        {
            PlayerScore playerScore = other.GetComponent<PlayerScore>();
            if (playerScore != null)
            {
                playerScore.AddScore(scoreValue); // Add score to the player
            }
            Destroy(gameObject); // Destroy the coin
        }
    }
}
