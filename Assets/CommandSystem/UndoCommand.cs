using UnityEngine;

namespace CommandSystem
{
    public class UndoCommand : MonoBehaviour
    {
        public KeyCode commandKey = KeyCode.X;
        void Update()
        {
            if (Input.GetKeyDown(commandKey))
            {
                CommandStackSingleton.Instance.UndoCommand();
               
            }
        }
    }
}