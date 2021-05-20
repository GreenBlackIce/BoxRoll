using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverScript : MonoBehaviour
{
    public PlayerMovment player;

    public GameObject gameOverUI;
    public GameObject scoreBoardUI;

    private void Update() 
    {
        if(player.hasHitObject)
        {
            Time.timeScale = 0f;
            scoreBoardUI.SetActive(false);
            gameOverUI.SetActive(true); 
            player.hasHitObject = false;
        } 
    }
   
}
