using UnityEngine;
using System.Collections;

public class GuyController : MonoBehaviour {
	public float horizontalSpeed = 0.01f;
	public float verticalSpeed = 2f;
	Rigidbody2D rbody;
	public GameObject bullet;

	bool facingRight = true;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		Debug.Log ("Start");
		print ("The objective of this game is to reach the end with the least amount of points. Fall out of the world and it's game over.");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveRight();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveLeft();
		}		
		if (Input.GetKeyDown (KeyCode.F)) {

	
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump ();

		}
      
	}
	void Flip(){
		Vector2 scale = transform.localScale;
		scale.x *= -1f;
		transform.localScale = scale;
		facingRight = !facingRight;
	}

	public void Jump(){
		rbody.AddForce (transform.up * 400.0f);
		//GetComponent<Rigidbody2D> ().AddForce (new Vector2 (2f, verticalSpeed)); 

		//Vector2 position = transform.position;

		//position.y += verticalSpeed;

		//transform.position = position;

	}

	void MoveLeft(){
		if (facingRight) {
			Flip();
		}
		Vector2 position = transform.position;
		position.x -= horizontalSpeed;
		transform.position = position;
	}

	void MoveRight(){
		if (!facingRight) {
			Flip();
		}
		Vector2 position = transform.position;
		position.x += horizontalSpeed;
		transform.position = position;
	}


}
