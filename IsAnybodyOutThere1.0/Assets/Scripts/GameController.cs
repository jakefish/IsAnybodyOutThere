using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public int gameLevel = 0;
    public int levelOneSpawnAmount; 
    public int levelTwoSpawnAmount; 
    public int levelThreeSpawnAmount; 
    public int levelFourSpawnAmount; 
    public int levelFiveSpawnAmount;
	public int numberOfZombiesToKill;
	public int numberOfZombiesToKill2;
	public int numberOfZombiesToKill3;
	public int numberOfZombiesToKill4;
	public int numberOfZombiesToKill5;
	public bool proceed = false;
    

	// Use this for initialization
	void Start () {
	    levelOneSpawnAmount = Random.Range(5, 15);
        levelTwoSpawnAmount = Random.Range(15, 25);
        levelThreeSpawnAmount = Random.Range(20, 35);
        levelFourSpawnAmount = Random.Range(30, 45);
        levelFiveSpawnAmount = Random.Range(40, 80);
		//print ("levelonespawnamount: " + levelOneSpawnAmount);
		numberOfZombiesToKill = levelOneSpawnAmount;
		numberOfZombiesToKill2 = levelTwoSpawnAmount;
		numberOfZombiesToKill3 = levelThreeSpawnAmount;
		numberOfZombiesToKill4 = levelFourSpawnAmount;
		numberOfZombiesToKill5 = levelFiveSpawnAmount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   


}
