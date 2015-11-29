using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	public GameController gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.FindObjectOfType(typeof(GameController)) as GameController;
		print ("value of numberofzombiestokill in zombiemovement : " + gc.GetComponent<GameController>().numberOfZombiesToKill);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-0.07f, 0.0f, 0.0f);

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            //print("Bullet hit me");
            Destroy(coll.gameObject);
            Destroy(gameObject);
			if(gc.GetComponent<GameController>().gameLevel == 0){
				//print ("here");
				gc.GetComponent<GameController>().numberOfZombiesToKill = gc.GetComponent<GameController>().numberOfZombiesToKill - 1;
				//print ("value of numberofzombiestokill in zombiemovement : " + gc.GetComponent<GameController>().numberOfZombiesToKill);
			}
			if(gc.GetComponent<GameController>().gameLevel == 1){
				//print("here2");
				gc.GetComponent<GameController>().numberOfZombiesToKill2--;
			}
			if(gc.GetComponent<GameController>().gameLevel == 2){
				gc.GetComponent<GameController>().numberOfZombiesToKill3--;
			}
			if(gc.GetComponent<GameController>().gameLevel == 3){
				gc.GetComponent<GameController>().numberOfZombiesToKill4--;
			}
			if(gc.GetComponent<GameController>().gameLevel == 4){
				gc.GetComponent<GameController>().numberOfZombiesToKill5--;
			}
        }
           

    }
}
