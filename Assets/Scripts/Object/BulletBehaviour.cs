using UnityEngine;

namespace Knpire.Object
{
    public class BulletBehaviour : MonoBehaviour
    {
        [SerializeField]
        [Header("Explosion particle to play when collide")]
        private GameObject explosion;

        [SerializeField]
        [Header("Explosion sound to play when collide")]
        private AudioClip explosionSound;

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
            this.GetComponent<AudioSource>().PlayOneShot(this.explosionSound);
            Destroy(this.gameObject);
        }
    }
}
