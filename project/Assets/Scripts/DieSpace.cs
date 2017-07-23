
using UnityEngine;

public class DieSpace : MonoBehaviour {

	public GameObject respovn;

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player"){
			other.transform.position = respovn.transform.position;
		}
	}

}
