using com.ootii.Messages;
using UnityEngine;

namespace Yardin
{
    public class YardinGameManager : MonoBehaviour
    {

        public Animator UI;
        private bool showed;

        private void Start()
        {
            MessageDispatcher.AddListener(YardinKeys.explore, Aiuda);
        }

        void Aiuda(IMessage rMessage)
        {
            Debug.Log("Explorando Hando");
        }

        public void Explore()
        {
            MessageDispatcher.SendMessage(YardinKeys.explore);
            UI.SetTrigger("ExploreShow");
        }
        public void ExitExplore()
        {
            UI.SetTrigger("ExploreHide");
        }
        public void GoToShip()
        {
            UI.SetTrigger("GoToShipShow");
        }
        public void ExitGoToShip()
        {
            UI.SetTrigger("GoToShipHide");
        }
        public void StrucutureLeft()
        {
            if(showed == false)
            {
                UI.SetTrigger("StructureLeftShow");
                showed = true;
            }
            else
            {
                UI.SetTrigger("StructureLeftHide");
                showed = false;
            }
        }
        public void StructureRight()
        {
            if (showed == false)
            {
                UI.SetTrigger("StructureRightShow");
                showed = true;
            }
            else
            {
                UI.SetTrigger("StructureRightHide");
                showed = false;
            }
        }
    }
}

