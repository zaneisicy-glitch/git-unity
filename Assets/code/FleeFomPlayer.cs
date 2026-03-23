using UnityEngine;
using UnityEngine.AI;
 
public class FleeFromPlayer : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform player;
    [SerializeField] private float fleeDistance = 10f;
 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
 
    void Update()
    {
        if (player == null) return;
 
        // Direction away from the player
        Vector3 fleeDirection = transform.position - player.position;
 
        // Calculate a point further away
        Vector3 fleeTarget = transform.position + fleeDirection.normalized * fleeDistance;
 
        // Move the agent to that point
        agent.SetDestination(fleeTarget);
    }
}