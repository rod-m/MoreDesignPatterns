using UnityEngine;
using UnityEngine.AI;

namespace CommandSystem
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class CommandController : BaseCommandController
    {
        private NavMeshAgent _agent;
   
        void Start() => _agent = GetComponent<NavMeshAgent>();
    
        internal override void DoActions()
        {
            if (Input.GetMouseButton(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out var hitInfo))
                {
                    var moveCommand = new MoveAgentCommand(hitInfo.point, _agent);
                    _commands.Enqueue(moveCommand);
                }
            }

            if (Input.GetMouseButton(1))
            {

            }
        }
    }
}
