using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour
{
	public GameObject rightRotationPoint = null;
	public GameObject leftRotationPoint = null;
	
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
		ProcessInput();
	
	
	
	}
	
	private void ProcessInput()
	{
		ProcessTracks();
		ProcessCabin();
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
		Transform cabin = transform.FindChild("ExcavatorCabinRoot");
		
		RotateCabin("HorizontalP1", cabin, 0.01f);		
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
	
	private void RotateCabin(string buttonName, Transform cabin, float speed)
	{
		cabin.transform.RotateAroundLocal(new Vector3(0, 1, 0),
											Input.GetAxis(buttonName) * speed);
	}
}
