using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {

            Debug.Log("We hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();

        }

    }

}
