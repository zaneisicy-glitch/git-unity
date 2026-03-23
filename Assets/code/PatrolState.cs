using GlosCol;
using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{
    public class PatrolState : State
    {
        private Vector3 patrolPoint;

        public PatrolState(EnemyAI enemy) : base(enemy) { }
        public override void Enter()
        {
            SetNewPatrolPoint();
        }

        public override void Update()
        {
            if (enemy.DistanceToPlayer() <= enemy.sightRange)
            {
                enemy.changeState(new ChaseState(enemy));
                return;
            }
            if (!enemy.agent.pathPending && enemy.agent.remainingDistance < 2f)
            {
                SetNewPatrolPoint();
            }
        }

        void SetNewPatrolPoint()
        {
            Vector3 randomDirection = Random.insideUnitSphere * 10f;
            randomDirection += enemy.transform.position;
            NavMeshHit hit;
            NavMesh.SamplePosition(randomDirection, out hit, 10f, NavMesh.AllAreas);
            patrolPoint = hit.position;
            enemy.agent.SetDestination(patrolPoint);
        }
    }
}
