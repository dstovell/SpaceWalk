using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

namespace Opsive.ThirdPersonController.Abilities
{
	public class CGF_gravity : Ability
	{
		public CGF_Character GetCharacter()
		{
			return m_GameObject.GetComponent<CGF_Character>();
		}

		public override bool CanStartAbility()
		{
			return (this.GetCharacter() != null);
		}

		public override bool CanStopAbility()
		{
			return (this.GetCharacter() == null);
		}

		public override bool UpdateRotation()
		{
			CGF_Character character = this.GetCharacter();
			if ((character != null) && character.IsInGravity())
			{
				//character.GetRotation();
				Debug.LogError("UpdateRotation");
			}
			return true;
		}
	}
}
