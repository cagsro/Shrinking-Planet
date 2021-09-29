using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (!GameManager.isGameStarted) // Oyun baslamadiysa
        {
            return;
        }
        if (other.transform.tag.Equals("Meteor")) //Arac Meteora carpti mi?
        {
            GameManager.instance.OnLevelCompleted();
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
    
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerStay(Collider other)
    {
        
    }
}
