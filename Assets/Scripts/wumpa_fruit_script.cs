using UnityEngine;
using System.Collections;

public class wumpa_fruit_script : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Crash");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){
		
		if(player.GetComponent <Collider>()==c)
			Destroy (this.gameObject);
	}
}
