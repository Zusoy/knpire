using UnityEngine;
using System.Collections;

namespace Knpire.Object
{
    using Game;

    public class BulletBehaviour : MonoBehaviour
    {
        [SerializeField]
        [Header("Explosion particle to play when collide")]
        private GameObject explosion;

        [SerializeField]
        [Header("The explosion sound")]
        private AudioClip explosionClip;

        private void Start()
        {
            Physics.IgnoreLayerCollision(0, 8);
        }

        private void OnCollisionEnter(Collision other)
        {
            this.Explode();
        }

        private void Explode()
        {
            GameObject explosionParticle = Instantiate(this.explosion, this.transform.position, Quaternion.identity);

            explosionParticle.GetComponent<ParticleSystem>().Play();

            GameManager.Instance.GetSoundManager().PlaySound(this.explosionClip);

            Destroy(this.gameObject);
        }
    }
}
