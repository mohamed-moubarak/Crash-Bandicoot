using UnityEngine;
using System.Collections;


public class crash_script : MonoBehaviour {
	public int WalkSpeed = 10;
	public int TurnSpeed = 50;
	public int JumpForce = 10;
//	private Animation anim;

	// Use this for initialization
	void Start () {
//		anim = gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Vertical");
		transform.Translate (Vector3.forward * v * WalkSpeed * Time.deltaTime);
		Rigidbody rb = GetComponent<Rigidbody> ();
		if (Input.GetButtonDown ("Jump")) {
			rb.AddForce (new Vector3 (0, JumpForce, 0), ForceMode.Impulse);
		}
		float h = Input.GetAxis ("Horizontal");
		transform.Rotate (new Vector3 (0, 1, 0) * h*Time.deltaTime*TurnSpeed);
	}
}
