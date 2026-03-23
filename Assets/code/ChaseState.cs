using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{
    public class ChaseState: State
    {
        public ChaseState(EnemyAI enemy) : base(enemy) { } 

        public override void Enter()
        {
            enemy.agent.isStopped = false;
        }


            // Start is called once before the first execution of Update after the MonoBehaviour is created
            void Start()
            {

            }

            // Update is called once per frame
            public override void Update()
            {
                enemy.agent.SetDestination(enemy.player.position);
                float distance = enemy.DistanceToPlayer();

                if (distance <= enemy.attackRange)
                {
                    enemy.changeState(new PatrolState(enemy));
                    return;
                }
                if (distance > enemy.sightRange)
                {
                    enemy.changeState(new SearchState(enemy));
                }
            }

    }
}
