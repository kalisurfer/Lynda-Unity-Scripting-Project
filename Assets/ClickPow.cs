using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickPow : MonoBehaviour {

	public List<GameObject> hitEffects = new List<GameObject>(); //public so we can manage in unity editor

	// Use this for initialization
	void Start () {


		if (hitEffects.Count < 1) {
			Debug.Log ("You must add at least one hit effect");
			this.enabled = false;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 clickPosition = Input.mousePosition;
			GameObject powObject = Instantiate (
				hitEffects[Random.Range(0,hitEffects.Count)], 
				clickPosition, 
				Quaternion.identity) as GameObject;
			powObject.transform.SetParent(this.transform); //this is the canvas needs to be done for the new gameobject to be drawn.
		}
	
	}
}
