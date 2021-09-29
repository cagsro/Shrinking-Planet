using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    private Touch touch;
    GameManager gameManager;
    public float speed =4;

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

    }
    // Update is called once per frame
    void Update()
    {

        if (!GameManager.isGameStarted || GameManager.isGameEnded) // Oyun baslamadiysa veya bittiyse
        {
            return;
        }
        transform.Translate(Vector3.forward * (speed) * Time.deltaTime); // ileri dogru hareket


        if (Input.touchCount > 0) // Dokunma varsa;
        {
            touch = Input.GetTouch(0); // Degiskeni atama atama

            if (touch.phase == TouchPhase.Moved) // Dokunma basladiginda;
            {
                transform.Rotate(0f,touch.deltaPosition.x*0.2f,0f); //Dondur
            }
        }
    }
}
