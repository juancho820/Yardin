using com.ootii.Messages;
using UnityEngine;

namespace Yardin
{
    public class YardinGameManager : MonoBehaviour
    {

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
        }
    }
}

