using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText; // Reference to the Text UI element for the score
    private int score = 0; // Player's score

    private void Start()
    {
        UpdateScoreText(); // Initialize the score text
    }

    public void AddScore(int amount)
    {
        score += amount; // Increase the score
        UpdateScoreText(); // Update the UI
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Update the text component
    }
}
