using UnityEngine;

namespace CommandSystem
{
    public class DisplayToggle : ICommandUndo
    {
        private GameObject _thing;
        public DisplayToggle(GameObject thing)
        {
            _thing = thing;
        }
        
        public void DoAction()
        {
            Debug.Log("Display Toggle Action");
            _thing.SetActive(!_thing.activeSelf);
        }

        public void UnDoAction()
        {
            _thing.SetActive(!_thing.activeSelf);
        }
    }
}