using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public void Load()
	{
		Invoke("delay", 0); 
	}
	public void delay()
	{
		Application.LoadLevel("Menu");
		
	}
}
