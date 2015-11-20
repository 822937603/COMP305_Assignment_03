/// Jonathan Lee 822937603
/// File: EnemyController.cs
/// Last Updated: November 20th, 2015
/// Controls the Enemy, instantiates explosion and provides a Life Decrement

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public Transform player;
	public float speed;

	public AudioSource skeletonDeathSound;
	public GameObject skeleton;
	public GameObject deathFire;
	public GameObject deathFireClone;

	public GameController gamecontroller;

	// Use this for initialization
	void Start () {
		skeletonDeathSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		//focuses the enemy to the player
		transform.LookAt (player);
		//move constantly towards player
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.position, step);
	}

	void DestroySkeleton (){
		Destroy (gameObject);
		//decrement a life
		this.gamecontroller.Life -= 1;
	}
	

	void OnTriggerEnter(Collider otherGameObject) {
		
		if (otherGameObject.tag == "Player") {
			//play death sound
			skeletonDeathSound.Play();
			//create explosion
			Instantiate(deathFire, skeleton.transform.position, Quaternion.identity);
			//destroy after delay for sound to play
			Invoke ("DestroySkeleton",0.5f);

		}
	}
}
