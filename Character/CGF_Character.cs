using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CircularGravityForce;

public class CGF_Character : MonoBehaviour 
{
	private Rigidbody rigid;
	private CGF currentCGF;

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
	    rigid = this.GetComponent<Rigidbody>();
	}

	private void CGF_OnApplyCGFEvent(CGF cgf, Rigidbody rigid, Collider coll)
	{
		if (this.rigid != rigid) 
		{
	        return;
		}

		Debug.LogError("CGF_OnApplyCGFEvent");

		this.currentCGF = cgf;
	}

	public bool IsInGravity()
	{
		return (this.currentCGF != null);
	}

	public Quaternion GetRotation()
	{
		return Quaternion.identity;
	}
}
