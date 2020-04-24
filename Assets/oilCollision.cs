using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class oilCollision : MonoBehaviour
{
    public GameObject gameOver;

    public GameObject cam;

    public GameObject self;

   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Main Char")
        {
            
            FindObjectOfType<GameManager>().EndGame();

            Time.timeScale = 0;
        }

        if (other.gameObject.name == "Soap(Clone)")
        {
            scoreScript.scoreValue += 50;
            Destroy(self);
        }


    }
}
