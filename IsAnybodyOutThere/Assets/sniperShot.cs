using UnityEngine;
using System.Collections;

public class sniperShot : MonoBehaviour {

    private AudioSource audio;
    public AudioClip snipershot;
    public GameObject bullet;
    

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(snipershot);

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 2.0f;
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(bullet, objectPosition, Quaternion.identity);
			Destroy(GameObject.Find("bullet_hole(Clone)"), 3);
        }
	}
}
