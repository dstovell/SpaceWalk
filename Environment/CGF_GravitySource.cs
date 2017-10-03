using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGF_GravitySource : MonoBehaviour {

	public CircularGravityForce.CGF gravitySource = null;

	void Awake() 
	{
		this.gravitySource = this.gameObject.GetComponent<CircularGravityForce.CGF>();

	}

	void Start()
	{
		CGF_GravityManager.Instance.AddSource(this);
	}
	
	// Update is called once per frame
	void Update () 
	{
				
	}

	public bool ContainsObject(GameObject obj)
	{
		return true;
		//gravitySource.
	}
}
