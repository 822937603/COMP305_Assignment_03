/// Jonathan Lee 822937603
/// File: GameController.cs
/// Last Updated: November 20th, 2015
/// Controls the Canvas, holds the background music

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public Text goldLabel;
	public Text lifeLabel;
	
	// PRIVATE INSTANCE VARIABLES
	private int _goldValue = 0;
	private int _liveValue = 5;
	
	// PUBLIC PROPERTIES
	public int Gold {
		get {
			return _goldValue;
		}
		set {
			_goldValue = value;
			this._updateHUD();
		}
	}
	
	public int Life {
		get {
			return _liveValue;
		}
		set {
			_liveValue = value;
			this._updateHUD();
		}
	}
	
	// Use this for initialization
	void Start () {
		this._updateHUD ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// PRIVATE METHODS
	private void _updateHUD() {
		this.goldLabel.text = "Gold: " + this._goldValue;
		this.lifeLabel.text = "Life: " + this._liveValue;
	}
}
