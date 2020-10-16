using UnityEngine;

namespace Knpire.Player
{
    using Game;

    public class PlayerHealthBehaviour : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                GameManager.Instance.OnPlayerDeath();
                Destroy(this.gameObject);
            }
        }
    }
}
