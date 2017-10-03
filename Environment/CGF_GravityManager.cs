using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGF_GravityManager : MonoBehaviour 
{
	static public CGF_GravityManager Instance = null;
	public List<CGF_GravitySource> Sources = null;

	void Awake() 
	{
		CGF_GravityManager.Instance = this;
		this.Sources = new List<CGF_GravitySource>();
	}
	
	void Update () 
	{
		
	}

	public void AddSource(CGF_GravitySource s)
	{
		if (!this.Sources.Contains(s))
		{
			this.Sources.Add(s);
		}
	}

	public CGF_GravitySource GetGravitySource(GameObject obj)
	{
		for (int i=0; i<this.Sources.Count; i++)
		{
			if (this.Sources[i].ContainsObject(obj))
			{
				return this.Sources[i];
			}
		}

		return null;
	}
}
