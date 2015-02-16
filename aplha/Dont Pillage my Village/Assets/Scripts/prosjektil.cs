using UnityEngine;
using System.Collections;

//Lager en funksjon som beregner avstand
public class prosjektil : MonoBehaviour {

	//Setter farten på kula 
	public float mySpeed = 10f;
	//Setter maks avstand
	public float myRange = 10f;
	//Lager en tom variabel
	private float myDist = 0f;

	// Update is called once per frame
	void Update () {
		//Forteller hvilken vei og hastight kula skal gå, altså fremover
		transform.Translate(Vector3.forward * Time.deltaTime * mySpeed);
		//Beregner avstanden
		myDist+= Time.deltaTime * mySpeed;
		//Hvis avstanden er lik myRange, kullaforsvinner
		if (myDist >= myRange)
						Destroy (gameObject);
		
	}
}
