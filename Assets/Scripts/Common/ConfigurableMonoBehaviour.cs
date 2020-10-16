using UnityEngine;

namespace Knpire.Common
{
    public class ConfigurableMonoBehaviour<T> : MonoBehaviour where T : ScriptableObject
    {
        [SerializeField]
        protected T settings;

        public T GetSettings()
        {
            return this.settings;
        }
    }
}
