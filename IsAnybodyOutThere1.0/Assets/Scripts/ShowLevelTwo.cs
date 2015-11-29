using UnityEngine;
using System.Collections;

public class ShowLevelTwo : MonoBehaviour {
	private SpriteRenderer mesh_renderer;
	public GameController gc;
	int counter = 0;
	// Use this for initialization
	void Start () {
		mesh_renderer = GetComponent<SpriteRenderer>();
		mesh_renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(gc.GetComponent<GameController>().gameLevel == 1 && counter == 0){
			mesh_renderer.enabled = true;
			gc.GetComponent<GameController> ().proceed = false;
			Invoke ("TurnOffText",5);
		}
	}
	void TurnOffText(){
		counter++;
		mesh_renderer.enabled = false;
		gc.GetComponent<GameController> ().proceed = true;
	}
}
