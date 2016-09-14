using UnityEngine;
using System.Collections;

namespace alisanCapstone
{
	public class Soldier_Animation: MonoBehaviour {

        private Enemy_Master enemyMaster;
        private Animator myAnimator;

		void OnEnable()
		{
            SetInitialReferences();
            enemyMaster.EventEnemyDie += DisableAnimator;
            enemyMaster.EventEnemyWalking += SetAnimationToWalk;
            enemyMaster.EventEnemyReachedNavTarget += SetAnimationToIdle;
            enemyMaster.EventEnemyAttack += SetAnimationToAttack;
            enemyMaster.EventEnemyDeductHealth += SetAnimationToStruck;

        }

		void OnDisable()
		{
            enemyMaster.EventEnemyDie -= DisableAnimator;
            enemyMaster.EventEnemyWalking -= SetAnimationToWalk;
            enemyMaster.EventEnemyReachedNavTarget -= SetAnimationToIdle;
            enemyMaster.EventEnemyAttack -= SetAnimationToAttack;
            enemyMaster.EventEnemyDeductHealth -= SetAnimationToStruck;
        }

		void SetInitialReferences()
		{
            enemyMaster = GetComponent<Enemy_Master>();

			GetComponent<Animation> ().Play ("Idle");

		}

        void SetAnimationToWalk()
        {
			GetComponent<Animation> ().Play ("Walk");
        }

        void SetAnimationToIdle()
        {
			GetComponent<Animation> ().Play ("Idle");

        }

        void SetAnimationToAttack()
        {
			GetComponent<Animation> ().Play ("StandingFire");

        }

        void SetAnimationToStruck(int dummy)
        {
			GetComponent<Animation> ().Play ("CrouchAimDown");
        }

        void DisableAnimator()
        {
			
        }

    }
}


