using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-0.07f, 0.0f, 0.0f);

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            print("Bullet hit me");
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
           

    }
}
