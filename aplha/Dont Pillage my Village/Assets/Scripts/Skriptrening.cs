using UnityEngine;
using System.Collections;

public class Skriptrening : MonoBehaviour {



	// Use this for initialization
	void Start () {
		int myInt = 5;
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	
	}
	int MultiplyByTwo(int number){

	int ret;
	ret = number *2;
	return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
