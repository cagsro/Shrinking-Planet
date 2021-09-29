using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    GameManager gameManager;
    public GameObject meteor;
    public int xPos;
    public int yPos;
    public int zPos;
    public int count;

    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        xPos=  Random.Range(-20,20);
        yPos=  Random.Range(-20,20);
        zPos=  Random.Range(-20,20);
        Instantiate(meteor,new Vector3(xPos,yPos,zPos),Quaternion.identity);
        yield return new WaitForSeconds(seconds: 1);
        StartCoroutine(Spawner());
          
    }
}
