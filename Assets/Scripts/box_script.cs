using UnityEngine;
using System.Collections;

public class box_script : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("Crash");
		if(player.transform.position.z < (this.transform.position+ new Vector3(0,0,5)).z && 
			player.transform.position.z > (this.transform.position- new Vector3(0,0,5)).z &&
			player.transform.position.x < (this.transform.position+ new Vector3(5,0,0)).x &&
			player.transform.position.x > (this.transform.position- new Vector3(5,0,0)).x){
			Destroy (this.gameObject);
		}
	}
}
