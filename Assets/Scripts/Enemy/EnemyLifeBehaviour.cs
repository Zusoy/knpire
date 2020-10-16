using UnityEngine;

namespace Knpire.Enemy
{
    using Game;

    public class EnemyLifeBehaviour : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Weapon")
            {
                GameManager.Instance.OnEnemyKilled();
                Destroy(this.gameObject);
            }
        }
    }
}