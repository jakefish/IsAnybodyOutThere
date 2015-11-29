using UnityEngine;
using System.Collections;

public class CampaignSpawner : MonoBehaviour {

	public int gameLevel = 0;
	public int levelOneSpawnAmount; 
	public int levelTwoSpawnAmount; 
	public int levelThreeSpawnAmount; 
	public int levelFourSpawnAmount; 
	public int levelFiveSpawnAmount;
	
	
	// Use this for initialization
	void Start () {
		levelOneSpawnAmount = Random.Range(0, 5);
		levelTwoSpawnAmount = Random.Range(5, 9);
		levelThreeSpawnAmount = Random.Range(10, 13);
		levelFourSpawnAmount = Random.Range(13, 15);
		levelFiveSpawnAmount = Random.Range(40, 80);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
