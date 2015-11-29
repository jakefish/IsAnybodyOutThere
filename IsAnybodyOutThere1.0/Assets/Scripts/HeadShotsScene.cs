using UnityEngine;
using System.Collections;

public class HeadShotsScene : MonoBehaviour {

	public void Load()
	{
		Invoke("delay", 1); 
	}
	public void delay()
	{
		Application.LoadLevel("HeadShot");
		print ("Loaded headshot");
	}
}
