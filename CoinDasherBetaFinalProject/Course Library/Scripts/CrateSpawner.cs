using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject Crate;

    //create instances
    public float roadWidth = 10f;
    public float roadLength = 50f;
    public int maxCrates = 20;
    public float spawnHeight = 0.5f;

    private Vector3 roadStartPosition;

    //spawn crates method
    private void Start()
    {
        roadStartPosition = transform.position;
        SpawnRandomCrates();
    }

    private void OnTriggerEnter(Collider other)
    {
        //check if the player crossed the trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player crossed the trigger. Spawning crates with the new road.");
            RespawnCratesWithRoad();
        }
    }

    private void SpawnRandomCrates()
    {
        if (Crate == null)
        {
            Debug.LogError("Crate prefab is not assigned!");
            return;
        }

        //spawn crates randomly method
        for (int i = 0; i < maxCrates; i++)
        {
            float randomX = Random.Range(-roadWidth / 4, roadWidth / 2);
            float randomZ = Random.Range(roadStartPosition.z, roadStartPosition.z + roadLength);

            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            Instantiate(Crate, spawnPosition, Quaternion.identity);
            Debug.Log($"Crate spawned at {spawnPosition}");
        }
    }
private void RespawnCratesWithRoad()
    {
        

        //update the roads position
        roadStartPosition = transform.position;

        //spawn new crates in new road
        SpawnRandomCrates();
    }
}