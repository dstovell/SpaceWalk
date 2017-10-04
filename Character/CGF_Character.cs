using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CircularGravityForce;

public class CGF_Character : MonoBehaviour 
{
	private Rigidbody rigid;
	private CGF currentCGF;

	public Vector3 SurfaceNormal = Vector3.up;

	//Awake is called when the script instance is being loaded
	void Awake()
	{
	    CGF.OnApplyCGFEvent += CGF_OnApplyCGFEvent;
	}

	//This function is called when the MonoBehaviour will be destroyed
	void OnDestroy()
	{
	    CGF.OnApplyCGFEvent -= CGF_OnApplyCGFEvent;
	}

	//Use this for initialization
	void Start()
	{
	    this.rigid = this.GetComponent<Rigidbody>();
	}

	private void CGF_OnApplyCGFEvent(CGF cgf, Rigidbody characterRB, Collider characterCollider)
	{
		if (this.rigid != characterRB)
		{
	        return;
		}

		//Debug.LogError("CGF_OnApplyCGFEvent");

		this.currentCGF = cgf;
	}

	public bool IsInGravity()
	{
		return (this.currentCGF != null);
	}

	public Quaternion GetRotation()
	{
		if (!IsInGravity()) 
		{
			return this.transform.rotation;
		}

		Vector3 forceDir = (this.currentCGF.transform.position - this.transform.position);
		forceDir.Normalize();

		Ray ray = new Ray(this.transform.position, forceDir); // cast ray downwards
		RaycastHit hit;
		this.SurfaceNormal = -1 * forceDir;
		if (Physics.Raycast(ray, out hit))
		{ 
			//this.SurfaceNormal = hit.normal;
		}

		// find forward direction with new surfaceNormal:
		Vector3 targetForward = Vector3.Cross(this.transform.right, this.SurfaceNormal);

		// align character to the new myNormal while keeping the forward direction:
		Quaternion targetRot = Quaternion.LookRotation(targetForward, this.SurfaceNormal);

		return targetRot;
	}
}
