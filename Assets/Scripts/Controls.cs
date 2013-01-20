using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log("R4P1 " +  Input.GetButton("R4P1").ToString());
	}
}
