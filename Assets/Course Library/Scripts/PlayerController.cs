using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //create instances
    private float speed = 40.0f;
    private float horizontalInput;
    private float forwardInput;
    public SpawnManager spawnManager;
    public bool gameOver;
    private Animator playerAnimator;


void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        //input from user
        horizontalInput = Input.GetAxis("Horizontal");


        //move vertically
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //move horizontally
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SpawnTrigger"))
            {
                spawnManager.SpawnTriggerEntered();
            }

    }

    private void OnCollisionEnter(Collision other)
        {
            //check if the collision is with a crate
            if (other.gameObject.CompareTag("Crate"))
            {
                gameOver = true;
                Debug.Log("Game Over!");

                //load game over screen
                SceneManager.LoadScene("GameOver");
            }
}


}