using UnityEngine;
using System.Collections;

public class LoadHeadshotsOnly : MonoBehaviour {

	public void Load()
	{
		Invoke("delay", 1); 
	}
	public void delay()
	{
		Application.LoadLevel("HeadShotsOnly");
		
	}
}
