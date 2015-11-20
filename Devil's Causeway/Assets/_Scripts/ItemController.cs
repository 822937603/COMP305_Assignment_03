/// Jonathan Lee 822937603
/// File: ItemController.cs
/// Last Updated: November 20th, 2015
/// Controls the Chest, instantiation of the smoke and coin collection sound

using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	public AudioSource chestCollect;
	public GameObject chest;
	public GameObject collectSmoke;
	public GameObject collectSmokeClone;

	public GameController gamecontroller;

	// Use this for initialization
	void Start () {
		chestCollect = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroyChest (){
		Destroy (gameObject);
		//increment 500 gold
		this.gamecontroller.Gold += 500;
	}

	void DestroySmoke () {
		Destroy (collectSmokeClone);
	}

	void OnTriggerEnter(Collider otherGameObject) {
		//Collision detection for colliding with the Player

		if (otherGameObject.tag == "Player") {
			//play collect sound
			chestCollect.Play();
			//create collected smoke
			collectSmokeClone = (GameObject) Instantiate(collectSmoke, chest.transform.position, Quaternion.identity);
			//destroy after a delay for sound, and for smoke to be viewed
			Invoke ("DestroyChest",0.5f);
			Destroy (collectSmokeClone, 3.0f);

			
		//}
	}
}
}
	

