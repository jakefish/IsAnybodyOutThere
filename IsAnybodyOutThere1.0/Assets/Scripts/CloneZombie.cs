using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CloneZombie : MonoBehaviour {

    public Transform SpawnPoint;
    public GameObject enemy;
    private float InstantiationTimer = 1.5f;
    public GameController gc;
	public int count = 0;
	bool showText = true;
	public Text text;
   
	void Start(){
		text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill;
	}
    void Update()
    {
		if (gc.GetComponent<GameController> ().proceed == true) {
			CreatePrefab ();
		}
    }

    void CreatePrefab()
    {

        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
			if(gc.GetComponent<GameController> ().proceed == true){
				text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill;
			if(gc.GetComponent<GameController>().gameLevel == 0){

                if(gc.GetComponent<GameController>().levelOneSpawnAmount > 0){
					gc.GetComponent<GameController>().levelOneSpawnAmount--;
						print ("enemies left to killdsdsdsdsdsd: " + gc.GetComponent<GameController>().numberOfZombiesToKill);
                    Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
                    InstantiationTimer = Random.Range(0.3f, 2.0f);

                }

				if(gc.GetComponent<GameController>().numberOfZombiesToKill <=0){
						print ("finished with level 0");
					gc.GetComponent<GameController>().gameLevel++;
				}
            }
			}
		
			if(gc.GetComponent<GameController> ().proceed == true){

			if(gc.GetComponent<GameController>().gameLevel == 1){
					text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill2;
				if(gc.GetComponent<GameController>().levelTwoSpawnAmount > 0){
					gc.GetComponent<GameController>().levelTwoSpawnAmount--;
					Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
					InstantiationTimer = Random.Range(0.3f, 2.0f);
				}
				if(gc.GetComponent<GameController>().numberOfZombiesToKill2 <=0){
					gc.GetComponent<GameController>().gameLevel++;
				}
			}
			}

			if(gc.GetComponent<GameController> ().proceed == true){

			if(gc.GetComponent<GameController>().gameLevel == 2){
					text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill3;
				if(gc.GetComponent<GameController>().levelThreeSpawnAmount > 0){
					gc.GetComponent<GameController>().levelThreeSpawnAmount--;
					Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
					InstantiationTimer = Random.Range(0.1f, 2.0f);
				}
				if(gc.GetComponent<GameController>().numberOfZombiesToKill3 <=0){
					gc.GetComponent<GameController>().gameLevel++;
				}
			}
			}

			if(gc.GetComponent<GameController> ().proceed == true){

			if(gc.GetComponent<GameController>().gameLevel == 3){
					text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill4;
				if(gc.GetComponent<GameController>().levelFourSpawnAmount > 0){
					gc.GetComponent<GameController>().levelFourSpawnAmount--;
					Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
					InstantiationTimer = Random.Range(0.1f, 2.0f);
				}
				if(gc.GetComponent<GameController>().numberOfZombiesToKill4 <=0){
					gc.GetComponent<GameController>().gameLevel++;
				}
			}
			}

			if(gc.GetComponent<GameController> ().proceed == true){
		
			if(gc.GetComponent<GameController>().gameLevel == 4){
					text.text = "Zombies left: " + gc.GetComponent<GameController>().numberOfZombiesToKill5;
				if(gc.GetComponent<GameController>().levelFiveSpawnAmount > 0){
					gc.GetComponent<GameController>().levelFiveSpawnAmount--;
					Instantiate(enemy, SpawnPoint.position, Quaternion.identity);
					InstantiationTimer = Random.Range(0.1f, 2.0f);
				}
				if(gc.GetComponent<GameController>().numberOfZombiesToKill5 <=0){
					gc.GetComponent<GameController>().gameLevel++;
						Application.LoadLevel("Menu");
				}
			}
			}
            }
        }

    }

