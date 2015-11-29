
using UnityEngine;
using System.Collections;

public class shootMachineGunBullet : MonoBehaviour {
	
	public float horizontalSpeed = 0.3f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (OneSecondTimer ());
	}
	
	IEnumerator OneSecondTimer()
	{
		//sleep 1 second
		yield return new WaitForSeconds(1.0f);
		//increment totalTime
		DestroyObject(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 position = transform.position;
		position.x += horizontalSpeed;
		transform.position = position;
	}
}
