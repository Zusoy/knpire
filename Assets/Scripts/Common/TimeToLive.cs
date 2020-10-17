using UnityEngine;
using System.Collections;

namespace Knpire.Common
{
    public class TimeToLive : MonoBehaviour
    {
        private void Start()
        {
            this.StartCoroutine("SelfDestroy");
        }

        private IEnumerator SelfDestroy()
        {
            yield return new WaitForSeconds(2);
            Destroy(this.gameObject);
        }
    }
}
