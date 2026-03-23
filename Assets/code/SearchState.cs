using UnityEngine;
using UnityEngine.AI;

namespace GlosCol
{
    using System.Threading;
    using UnityEngine;
    public class SearchState : State
    {
        private float SearchTime = 3f;
        private float searchTime;
        private float timer;

        public SearchState(EnemyAI enemy) : base(enemy) { }

        public override void Enter()
        {
            timer = 0f;
        }
        public override void Update()
        {
            timer += Time.deltaTime;

            if (enemy.DistanceToPlayer() <= enemy.sightRange)
            {
                enemy.changeState(new ChaseState(enemy));
                return;
            }
            if (timer >= searchTime)
            {
                enemy.changeState(new PatrolState(enemy));
            }
        }
    }
}
