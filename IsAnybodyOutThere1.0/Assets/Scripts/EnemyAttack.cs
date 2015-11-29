using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
	public int attackDamage = 10;               // The amount of health taken away per attack.
	public GameObject blood;
	public GameObject armAndLeg;
	public GameObject arms;
	public GameObject moreBlood;
	public GameObject arm;
	public AudioClip bloodSplat;
	private AudioSource audio;
	public List<GameObject> zombieParts = new List<GameObject>();


	System.Random rnd = new System.Random();

	Animator anim;                              // Reference to the animator component.

	GameObject tower;                          // Reference to the player GameObject.
	TowerHealth towerHealth;                  // Reference to the player's health.
	//EnemyHealth enemyHealth;                    // Reference to this enemy's health.
	bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
	float timer;                                // Timer for counting up to the next attack.
	

	void Start(){

		audio = GetComponent<AudioSource>();
	}
	void Awake ()
	{
		// Setting up the references.
		tower = GameObject.FindGameObjectWithTag ("Tower");
		towerHealth = tower.GetComponent <TowerHealth> ();

		//enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent <Animator> ();
		zombieParts.Add (blood);
		zombieParts.Add (armAndLeg);
		zombieParts.Add (arms);
		zombieParts.Add (arm);
		zombieParts.Add (moreBlood);
	}
	
	
	void OnCollisionEnter2D (Collision2D other)
	{
		print (other.gameObject.name);
		if(other.gameObject.name == "WaterTower")
		{
			playerInRange = true;
		}
		if(other.gameObject.tag == "PlayerBullet")
		{

			int rInt = rnd.Next(0, 4);
			Instantiate(zombieParts[rInt], transform.position, Quaternion.identity);
			audio.clip = bloodSplat;
			audio.Play();
			StartCoroutine (OneSecondTimer ());
		}
	}
	
	
	void OnTriggerExit (Collider other)
	{
		// If the exiting collider is the player...
		if(other.gameObject == tower)
		{
			// ... the player is no longer in range.
			playerInRange = false;
		}
	}
	
	
	void Update ()
	{
		// Add the time since Update was last called to the timer.
		timer += Time.deltaTime;
		
		// If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
		if(timer >= timeBetweenAttacks && playerInRange/* && enemyHealth.currentHealth > 0*/)
		{
			// ... attack.
			Attack ();
		}
		
		// If the player has zero or less health...
		if(towerHealth.currentHealth <= 0)
		{
			// ... tell the animator the player is dead.
			anim.SetTrigger ("PlayerDead");
		}
		if (towerHealth.currentHealth == 0) {
			Destroy(tower);
			Application.LoadLevel("GameOver");

		}
	}
	IEnumerator OneSecondTimer()
	{
		//sleep 1 second
		yield return new WaitForSeconds(1.0f);
		//increment totalTime

	

	}
	/*
	void Start () {
		StartCoroutine (OneSecondTimer ());
	}
	

	
	// Update is called once per frame
	void Update () {
		Vector2 position = transform.position;
		position.x += horizontalSpeed;
		transform.position = position;
	}
} */
	
	void Attack ()
	{
		// Reset the timer.
		timer = 0f;
		
		// If the player has health to lose...
		if(towerHealth.currentHealth > 0)
		{
			// ... damage the player.
			towerHealth.TakeDamage (attackDamage);
		}
	}
}