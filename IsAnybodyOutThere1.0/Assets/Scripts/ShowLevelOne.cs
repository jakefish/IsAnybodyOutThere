using UnityEngine;
using System.Collections;

public class ShowLevelOne : MonoBehaviour {
	private SpriteRenderer mesh_renderer;
	public GameController gc;
	// Use this for initialization
	void Start () {
		mesh_renderer = GetComponent<SpriteRenderer>();
		gc.GetComponent<GameController> ().proceed = false;
		Invoke ("TurnOffText", 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TurnOffText(){
		mesh_renderer.enabled = false;
		gc.GetComponent<GameController> ().proceed = true;
	}
}
