using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour
{
	public GameObject rightRotationPoint = null;
	public GameObject leftRotationPoint = null;
	public GameObject boomToCabinJoint = null;
	
	private Transform cabin = null;
	private Transform boom = null;
	
	// Use this for initialization
	void Start ()
	{
	 	this.cabin = transform.FindChild("ExcavatorCabinRoot");	
		this.boom = cabin.FindChild("ExcavatorBoomRoot");	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log("X axis " + Input.GetAxis("HorizontalP1").ToString());
		
		
	}
	
	void FixedUpdate()
	{
		ProcessInput();
	
	
	
	}
	
	private void ProcessInput()
	{
		ProcessTracks();
		ProcessCabin();
		ProcessBoom();
	}
	
	private void ProcessTracks()
	{
		RotateBaseByTracks("L1P1", rightRotationPoint.transform.position, 1f);
		RotateBaseByTracks("R1P1", leftRotationPoint.transform.position, -1f);
		RotateBaseByTracks("L2P1", rightRotationPoint.transform.position, -1f);
		RotateBaseByTracks("R2P1", leftRotationPoint.transform.position, 1f);
	}
	
	private void ProcessCabin()
	{
		RotateCabin("HorizontalP1", 0.01f);		
	}
	
	private void ProcessBoom()
	{
		RotateBoom("VerticalP1", 0.01f);		
	}
	
	private void RotateBaseByTracks(string buttonName, Vector3 rotationPoint, float speed)
	{
		if(Input.GetButton(buttonName))
		{
			this.transform.RotateAround ( rotationPoint,
										new Vector3(0, 1, 0),
										speed);
		}
	}
	
	private void RotateCabin(string buttonName, float speed)
	{
		cabin.transform.RotateAroundLocal(new Vector3(0, 1, 0),
											Input.GetAxis(buttonName) * speed);
	}
	
	private void RotateBoom(string buttonName, float speed)
	{
		boom.transform.RotateAroundLocal(new Vector3(1, 0, 0),
										Input.GetAxis(buttonName) * speed);													
	}
}
