using UnityEngine;
using System.Collections;

public class LoadInstructions : MonoBehaviour {

	public void Load()
	{
		Invoke("delay", 1); 
	}
	public void delay()
	{
		Application.LoadLevel("HowToPlay");

	}
}
