using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
    public GameObject bullet;
    float speed = 0.5f;
    private AudioSource audio;
    public AudioClip gunShot;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x +3, transform.position.y);
            Vector2 direction = target - myPos;
            direction.Normalize();
            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
            GameObject projectile = (GameObject)Instantiate(bullet, myPos, rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
			Destroy(GameObject.Find("bullet(Clone)"), 1);
            audio.clip = gunShot;
            audio.Play();
        }
    }
}
