using UnityEngine;
using UnityEngine.AI;

namespace CommandSystem
{
    public class MoveAgentCommand : ICommand
    {
        private readonly NavMeshAgent _agent;
        private readonly Vector3 _target;

        public MoveAgentCommand(Vector3 target, NavMeshAgent agent)
        {
            _target = target;
            _agent = agent;
        }

        public void DoAction()
        {
            _agent.SetDestination(_target);
        }

        public bool isDone => _agent.remainingDistance <= _agent.stoppingDistance;

        public void UnDoAction()
        {
            
        }
    }
}