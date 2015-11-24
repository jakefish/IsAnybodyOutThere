using UnityEngine;
using System.Collections;

public class CloneZombie : MonoBehaviour {

    public Transform SpawnPoint;
    public GameObject enemy;
    private float InstantiationTimer = 1.5f;
    public GameController gc;
   
    

    // Use this for initialization
    void Start()
    {

    }
    

    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
			print ("1");
            if(gc.GetComponent<GameController>().gameLevel == 0){

                if(gc.GetComponent<GameController>().levelOneSpawnAmount > 0){
                    gc.GetComponent<GameController>().levelOneSpawnAmount = gc.GetComponent<GameController>().levelOneSpawnAmount -1;
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = 2f;
                }
            }
            if (gc.GetComponent<GameController>().gameLevel == 1)
            {
				print ("2");
                if (gc.GetComponent<GameController>().levelTwoSpawnAmount > 0)
                {
                    gc.GetComponent<GameController>().levelTwoSpawnAmount = gc.GetComponent<GameController>().levelTwoSpawnAmount - 1;
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = 2f;
                }
            }
            if (gc.GetComponent<GameController>().gameLevel == 2)
            {

                if (gc.GetComponent<GameController>().levelThreeSpawnAmount > 0)
                {
                    gc.GetComponent<GameController>().levelThreeSpawnAmount = gc.GetComponent<GameController>().levelThreeSpawnAmount - 1;
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = 2f;
                }
            }
            if (gc.GetComponent<GameController>().gameLevel == 3)
            {

                if (gc.GetComponent<GameController>().levelFourSpawnAmount > 0)
                {
                    gc.GetComponent<GameController>().levelFourSpawnAmount = gc.GetComponent<GameController>().levelFourSpawnAmount - 1;
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = 2f;
                }
            }
            if (gc.GetComponent<GameController>().gameLevel == 4)
            {

                if (gc.GetComponent<GameController>().levelFiveSpawnAmount > 0)
                {
                    gc.GetComponent<GameController>().levelFiveSpawnAmount = gc.GetComponent<GameController>().levelFiveSpawnAmount - 1;
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = 2f;
                }
            }   
            }
        }

    }

