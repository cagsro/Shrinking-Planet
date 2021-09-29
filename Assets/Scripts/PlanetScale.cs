using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScale : MonoBehaviour
{
	public float scaleSpeed = .02f;

	void Update ()
	{
        if (!GameManager.isGameStarted) // Oyun baslamadiysa
        {
            return;
        }
		transform.localScale *= 1f - scaleSpeed * Time.deltaTime;
	}
}
