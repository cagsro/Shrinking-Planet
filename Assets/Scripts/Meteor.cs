using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Destroyer());
    }

	IEnumerator Destroyer()
    {
        Destroy(gameObject,20f);
        yield return new WaitForSeconds(seconds: 3);
        StartCoroutine(Destroyer());
          
    }
}
