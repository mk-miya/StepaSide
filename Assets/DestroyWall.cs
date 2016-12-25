
using UnityEngine;
using System.Collections;

public class DestroyWall : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0f, 0f, 0.2f);
	}

	//void OnCollisionEnter(Collision other){
	void OnTriggerEnter(Collider other) {	
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag") {
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);
		}
	}
}

