using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin; // Reference to the coin prefab

    public float roadWidth = 10f; // Total width of the road
    public float roadLength = 50f; // Total length of the road
    public int maxCoins = 20; // Maximum number of coins to spawn
    public float spawnHeight = 0.5f; // Height at which coins spawn above the road

    private Vector3 roadStartPosition; // Position to reset the road

    private void Start()
    {
        roadStartPosition = transform.position; // Record the initial position of the spawner
        SpawnRandomCoins(); // Spawn coins at the start
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player crossed the trigger
        if (other.CompareTag("Player")) // Ensure the player GameObject is tagged as 'Player'
        {
            Debug.Log("Player crossed the trigger. Spawning coins with the new road.");
            RespawnCoinsWithRoad();
        }
    }

    private void SpawnRandomCoins()
    {
        if (Coin == null)
        {
            Debug.LogError("Coin prefab is not assigned!");
            return;
        }

        // Spawn coins randomly across the road area
        for (int i = 0; i < maxCoins; i++)
        {
            float randomX = Random.Range(-roadWidth / 4, roadWidth / 2); // Random X position within the road width
            float randomZ = Random.Range(roadStartPosition.z, roadStartPosition.z + roadLength); // Random Z position within the road length

            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            Instantiate(Coin, spawnPosition, Quaternion.identity);
            Debug.Log($"Coin spawned at {spawnPosition}");
        }
    }

    private void RespawnCoinsWithRoad()
    {
        // Update the road's start position for the new road section
        roadStartPosition = transform.position;

        // Spawn new coins for the new road
        SpawnRandomCoins();
    }
}
