using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public GameObject gameOver;

    public GameObject win;
    // Start is called before the first frame update
    public void EndGame()
    {
        Debug.Log("Game Over");
        gameOver.transform.position = player.transform.position;
        
    }

    public void RestartGame()
    {
        Object[] allObjects = FindObjectsOfType(typeof(GameObject));
        Debug.Log("Restarted Game");
        

    }
    public void WinGame()
    {
        Debug.Log("You Win");
        win.transform.position = player.transform.position;
    }
}
