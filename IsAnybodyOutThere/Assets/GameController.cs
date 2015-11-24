using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public int gameLevel = 0;
    public int levelOneSpawnAmount; 
    public int levelTwoSpawnAmount; 
    public int levelThreeSpawnAmount; 
    public int levelFourSpawnAmount; 
    public int levelFiveSpawnAmount;
    

	// Use this for initialization
	void Start () {
	    levelOneSpawnAmount = Random.Range(5, 15);
        levelTwoSpawnAmount = Random.Range(15, 25);
        levelThreeSpawnAmount = Random.Range(20, 35);
        levelFourSpawnAmount = Random.Range(30, 45);
        levelFiveSpawnAmount = Random.Range(40, 80);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   


}
