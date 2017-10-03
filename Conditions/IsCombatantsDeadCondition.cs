using UnityEngine;
using System.Collections;
using Opsive.ThirdPersonController.Wrappers;

namespace DogFight
{

public class IsCombatantDeadCondition : DSTools.Condition
{
	public CharacterHealth [] Combatants;

	public override bool IsConditionMet()
	{
		bool allDead = true;
			for (int i=0; i<this.Combatants.Length; i++)
		{
			CharacterHealth d = this.Combatants[i];
			if ((d != null) && d.IsAlive())
			{
				allDead = false;
				break;
			}
		}
		return allDead;
	}
}

}
