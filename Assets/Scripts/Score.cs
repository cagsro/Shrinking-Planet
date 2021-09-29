using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public float score;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameStarted || GameManager.isGameEnded) // Oyun baslamadiysa veya bittiyse
        {
            return;
        }
        scoreText.text =score.ToString("0");
        score += 20f*Time.deltaTime;
    }
}
