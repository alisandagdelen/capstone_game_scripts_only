using UnityEngine;
using System.Collections;

namespace alisanCapstone
{
	public class Enemy_NavPauseBoss : MonoBehaviour {

        private Enemy_Master enemyMaster;
        private NavMeshAgent myNavMeshAgent;
        private float pauseTime = 1;
		int cnt = 0;
        void OnEnable()
		{
            SetInitialReferences();
            enemyMaster.EventEnemyDie += DisableThis;
            enemyMaster.EventEnemyDeductHealth += PauseNavMeshAgent;
		}

		void OnDisable()
		{
            enemyMaster.EventEnemyDie -= DisableThis;
            enemyMaster.EventEnemyDeductHealth -= PauseNavMeshAgent;
        }

		void SetInitialReferences()
		{
            enemyMaster = GetComponent<Enemy_Master>();
            if (GetComponent<NavMeshAgent>() != null)
            {
                myNavMeshAgent = GetComponent<NavMeshAgent>();
            }
        }

        void PauseNavMeshAgent(int dummy)
        {
            if (myNavMeshAgent != null)
            {
                if (myNavMeshAgent.enabled)
				{   cnt++;
					if (cnt == 33) {
						myNavMeshAgent.ResetPath ();
						enemyMaster.isNavPaused = true;
						StartCoroutine (RestartNavMeshAgent ());
						cnt = 0;
					}
                }
            }
        }

        IEnumerator RestartNavMeshAgent()
        {
            yield return new WaitForSeconds(pauseTime);
            enemyMaster.isNavPaused = false;
        }

        void DisableThis()
        {
            StopAllCoroutines();
        }
	}
}


