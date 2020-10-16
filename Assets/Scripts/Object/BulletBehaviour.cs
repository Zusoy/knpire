using UnityEngine;
using System.Collections;

namespace Knpire.Object
{
    /// <summary>
    /// Handle Bullet Time to Live
    /// </summary>
    public class BulletBehaviour : MonoBehaviour
    {
        [SerializeField]
        [Header("Bullet time to live (s)")]
        private float timeToLive;

        private void Start()
        {
            this.StartCoroutine("WaitForDestroy");
        }

        private IEnumerator WaitForDestroy()
        {
            yield return new WaitForSeconds(this.timeToLive);
            Destroy(this.gameObject);
        }
    }
}
