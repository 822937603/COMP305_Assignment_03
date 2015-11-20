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
		
		transform.LookAt (player);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.position, step);
	}

	void DestroySkeleton (){
		Destroy (gameObject);
		this.gamecontroller.Life -= 1;
	}
	

	void OnTriggerEnter(Collider otherGameObject) {
		//Collision detection for colliding with the Player
		
		if (otherGameObject.tag == "Player") {
			skeletonDeathSound.Play();
			//deathFireClone = (GameObject) 
			Instantiate(deathFire, skeleton.transform.position, Quaternion.identity);
			Invoke ("DestroySkeleton",0.5f);
			//Destroy (deathFireClone, 3.0f);
			
			
			//}
		}
	}
}
