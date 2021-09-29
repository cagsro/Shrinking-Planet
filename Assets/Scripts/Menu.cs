using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator animator;

	public void StartGame ()
	{
		animator.SetTrigger("Start");
	}

}
