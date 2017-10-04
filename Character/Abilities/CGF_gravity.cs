using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

namespace Opsive.ThirdPersonController.Abilities
{
	public class CGF_gravity : Ability
	{
		private float lerpSpeed = 10; // smoothing speed

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

		public override bool IsConcurrentAbility()
		{
			return true;
		}

		public override bool UpdateRotation()
		{
			CGF_Character character = this.GetCharacter();
			if ((character != null) && character.IsInGravity())
			{
				//character.GetRotation();
				//character.transform.rotation = Quaternion.Lerp(character.transform.rotation, character.GetRotation(), lerpSpeed*Time.deltaTime);
				character.transform.rotation = character.GetRotation();
			}
			return true;
		}
	}
}
