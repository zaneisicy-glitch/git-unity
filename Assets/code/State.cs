using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{
    public abstract class State
    {
        protected EnemyAI enemy;
        public State(EnemyAI enemy)
        {
            this.enemy = enemy;
        }
        public virtual void Enter() { }
        public virtual void Exit() { }
        public virtual void Update() { }
    }
}
