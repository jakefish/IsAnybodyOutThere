using UnityEngine;
using System.Collections;

public class SoldierController : MonoBehaviour {
	bool facingRight = true;

	public float horizontalSpeed = 0.01f;
	public float verticalSpeed = 2f;
	Rigidbody2D rbody;
	public GameObject bullet;
	Animator anim;




	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveRight();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveLeft();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump ();
			
		}
		if (Input.GetKey (KeyCode.F))
		{
			Shoot();
		}
	
	}
	void Flip(){
		Vector2 scale = transform.localScale;
		scale.x *= -1f;
		transform.localScale = scale;
		facingRight = !facingRight;
	}

	void MoveLeft(){
		if (facingRight) {
			Flip();
		}
		print(Mathf.Abs(Input.GetAxis("Horizontal")));
		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
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
		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

	}

	public void Jump(){
		print ("JUmp");
		//rbody.AddForce (transform.up * 400.0f);
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (2f, verticalSpeed)); 
		Vector2 position = transform.position;
		position.y += verticalSpeed;
		transform.position = position;

	
	}

	void Shoot(){
		Instantiate (bullet, transform.position, Quaternion.identity);
	}
		

	}


