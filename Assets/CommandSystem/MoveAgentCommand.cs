using UnityEngine;
using UnityEngine.AI;

namespace CommandSystem
{
    public class MoveAgentCommand : ICommand
    {
        private readonly Vector3 _target;
        private readonly NavMeshAgent _agent;
        public MoveAgentCommand(Vector3 target, NavMeshAgent agent)
        {
            _target = target;
            _agent = agent;
        }
        public void DoAction()
        {
            _agent.SetDestination(_target);
        }

        public void UnDoAction()
        {
            
        }

        public bool isDone => _agent.remainingDistance <= _agent.stoppingDistance;
    }
}