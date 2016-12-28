using UnityEngine;
using System.Collections;


public class crash_script : MonoBehaviour {
	public int speed = 1;
//	private Animation anim;

	// Use this for initialization
	void Start () {
//		anim = gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Vertical");
		transform.Translate (Vector3.forward * v * speed * Time.deltaTime);
//		if (Input.GetButtonDown ("Jump")) {
//			anim.Play ("crash_spin");
//		}
		float h = Input.GetAxis ("Horizontal");
		if (Input.GetButtonDown ("Horizontal")) {
			if (Input.GetAxis ("Horizontal") > 0) {
				transform.Rotate (new Vector3 (0, 1, 0) * 90);
				transform.Translate (Vector3.forward * speed * Time.deltaTime);
			} else {
				transform.Rotate (new Vector3 (0, 1, 0) * -90);
				transform.Translate (Vector3.forward * speed * Time.deltaTime);
			}

		}

	}
}
