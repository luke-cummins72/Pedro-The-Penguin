using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.onPlay.AddListener(ActivatePlayer);
    }

    private void ActivatePlayer()
    {
        gameObject.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            GameManager.Instance.GameOver();

            // Tell Arduino LED RED
            FindObjectOfType<ArduinoController>().PlayerDied();
        }
    }
}

