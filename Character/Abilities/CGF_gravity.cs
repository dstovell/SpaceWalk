using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

namespace Opsive.ThirdPersonController.Abilities
{
	public class CGF_gravity : Ability
	{
		public override bool CanStartAbility()
		{
			return true;
		}

		public override bool CanStopAbility()
		{
			return false;
		}

		public override bool UpdateRotation()
		{
			return true;
			//m_GameObject.transform.rotation;
		}
	}
}
