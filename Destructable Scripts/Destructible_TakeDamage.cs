using UnityEngine;
using System.Collections;

namespace alisanCapstone
{
	public class Destructible_TakeDamage : MonoBehaviour {

        private Destructible_Master destructibleMaster;

		void Start () 
		{
            SetInitialReferences();
		}

		void SetInitialReferences()
		{
            destructibleMaster = GetComponent<Destructible_Master>();
		}

        public void ProcessDamage(int damage)
        {
            destructibleMaster.CallEventDeductHealth(damage);
        }
	}
}


