﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractive
{
	void OnInteract();	
}

public class BaseInteractive : IInteractive
{
	public void OnInteract()
	{
		Debug.Log("I INTERACTED!");
	}
}
