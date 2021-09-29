using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static bool isGameStarted = false;
    public static bool isGameEnded = false;
    public GameObject finishScreen;
    public GameObject startScreen;
    public GameObject gameOverScreen;

    
    private void Awake()
    {        
        if (instance == null)
        {
            instance = this;
        }
    }

     // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
        isGameEnded = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLevelStarted()
    {
        isGameStarted = true;
        startScreen.SetActive(false);
    }
    public void OnLevelEnded()
    {
        
    }
    public void OnLevelCompleted() // Bitis ekranini cagirma
    {
        gameOverScreen.SetActive(true);
        isGameEnded = true;
    }

    public void OnLevelFailed() // Game Over ekranini cagirma
    {
        //gameOverScreen.SetActive(true);
        isGameEnded = true;
    }
    public void Restart ()
    {
        SceneManager.LoadScene("Game");
    }
}
