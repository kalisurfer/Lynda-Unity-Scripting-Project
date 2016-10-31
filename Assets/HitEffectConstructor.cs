using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HitEffectConstructor : MonoBehaviour {

	public Sprite spriteToUse;
	public bool hasRandomMovement;
	public float decayTime;

	// Use this for initialization
	void Start () {
		Decay decayScript = this.GetComponent<Decay> ();
		if (decayScript != null) {
			decayScript.decaySeconds = decayTime;
		}

		if (hasRandomMovement) {
			this.gameObject.AddComponent<MoveInRandomDirection> ();
		}
		Image imageScript = this.GetComponent<Image> ();
		imageScript.sprite = spriteToUse;
	
	}
	

}
