using UnityEngine;
using System.Collections;

public class Projectile_Cannon : MonoBehaviour {

	public float mySpeed = 10.0f;
	public float myRange = 10.0f;
	private float myDist = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
		myDist += Time.deltaTime * mySpeed;
		if (myDist >= myRange) {
			Destroy(gameObject);
		}
	}
}
