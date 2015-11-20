using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	public AudioSource chestCollect;
	public GameObject chest;
	public GameObject collectSmoke;
	public GameObject collectSmokeClone;

	// Use this for initialization
	void Start () {
		chestCollect = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroyChest (){
		Destroy (gameObject);
	}

	void DestroySmoke () {
		Destroy (collectSmokeClone);
	}

	void OnTriggerEnter(Collider otherGameObject) {
		//Collision detection for colliding with the Player

		if (otherGameObject.tag == "Player") {
			chestCollect.Play();
			collectSmokeClone = (GameObject) Instantiate(collectSmoke, chest.transform.position, Quaternion.identity);
			Invoke ("DestroyChest",0.5f);
			Destroy (collectSmokeClone, 3.0f);

			
		//}
	}
}
}
	

