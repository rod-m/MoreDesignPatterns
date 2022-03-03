using UnityEngine;

namespace CommandSystem
{
    public class CommanderActions : MonoBehaviour
    {
 
        public GameObject _thing;
        public KeyCode commandKey = KeyCode.L;
        private void Update()
        {
            if (Input.GetKeyDown(commandKey))
            {
                Debug.Log("Toggle Action");
                CommandStackSingleton.Instance.ExecuteCommand(new DisplayToggle(_thing));
               
            }
        }
    }
}