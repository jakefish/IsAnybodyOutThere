using UnityEngine;
using System.Collections;

public class RegularRed : MonoBehaviour {
	
	private SpriteRenderer mesh_renderer;
	
	bool hover = false;
	void Start()
	{
		mesh_renderer = GetComponent<SpriteRenderer>();
		mesh_renderer.enabled = false;
	}
	void OnMouseOver()
	{
		print(gameObject.name);
		mesh_renderer.enabled = true;
	}
	void OnMouseExit()
	{
		mesh_renderer.enabled = false;
	}
}
