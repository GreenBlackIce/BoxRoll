using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownScript : MonoBehaviour
{
    
    public Text countdownText;
    private float countdownTime = 3f;

    void Update()
    {
        countdownTime -= Time.deltaTime * 1f;
        countdownText.text = countdownTime.ToString("0");

        if(countdownTime <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
