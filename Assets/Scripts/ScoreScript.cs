using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public Text scroreText;

    void Update()
    {
        scroreText.text = (player.position.z - 1).ToString("0");
    }
}
