using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log("X axis " + Input.GetAxis("HorizontalP1").ToString());
		
		
	}
	
	void FixedUpdate()
	{
			if(Input.GetAxis("HorizontalP1") > 0)
		{			
			this.transform.RotateAround ( new Vector3(this.transform.position.x,
													this.transform.position.y,
													this.transform.position.z),
										new Vector3(0,1, 0),
										1f);
		}
		
		if(Input.GetAxis("HorizontalP1") < 0)
		{
			this.transform.Translate(-0.01f, 0, 0);
		}
	
	}
}
