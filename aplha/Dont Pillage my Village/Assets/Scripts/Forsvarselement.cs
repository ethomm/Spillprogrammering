using UnityEngine;
using System.Collections;

public class Forsvarselement : MonoBehaviour {
	//Lager variabler
	public GameObject projektile;
	public float reloadTime = 1f;
	public float turnSpeed = 5f;
	public float skytePause = .25f;
	//Her kan det legges inn en effekt om man har noen
	public Transform towerTarget;
	public Transform skyteRettning;

	private Quaternion bevegelsesRadius;
	private float nesteSkudd = 0f;
	private float nesteBevegelse = 0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (towerTarget)
				if(Time.time >=nesteSkudd)
						SkytProsjektil();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Enemy")
						nesteSkudd = Time.time + (reloadTime * .5f);
						towerTarget = other.gameObject.transform;
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.transform == towerTarget)
						towerTarget = null;
	}
	

	void SkytProsjektil(){
		nesteSkudd = Time.time + reloadTime;
		nesteBevegelse = Time.time + skytePause;
		//Instantiate (prosjektil, Fe_Tower_Muzzle);
	
	}

}