using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR;

namespace GlosCol
{
    public class EnemyAI : MonoBehaviour
    {
        public Transform player;
        public NavMeshAgent agent;
        [Header("ranges")]
        public float sightRange = 10f;
        public float attackRange = 2f;

        [HideInInspector] public State currentState;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            changeState(new PatrolState(this));
        }

        // Update is called once per frame
        void Update()
        {
            currentState?.Update();
        }

        public void changeState(State newState)
        {
            if (currentState != null)
                currentState.Exit();

            currentState = newState;
            currentState.Enter();
        }

        public float DistanceToPlayer()
        {
            return Vector3.Distance(transform.position, player.position);
        }
    }
}

