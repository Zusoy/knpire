using UnityEngine;

namespace Knpire.Player
{
    /// <summary>
    /// Handle Player Shooting
    /// </summary>
    public class ShootBehaviour : MonoBehaviour
    {
        [SerializeField]
        [Header("The GameObject to Shoot")]
        private GameObject bullet;

        [SerializeField]
        [Header("Position of bullet to spawn on Tank")]
        private Transform shootPoint;

        [SerializeField]
        [Header("The turret strength")]
        private float turretStrength;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                this.Shoot();
            }
        }

        private void Shoot()
        {
            GameObject currentBullet = Instantiate(bullet, this.shootPoint.transform.position, this.transform.rotation);
            Rigidbody bulletPhysic = currentBullet.GetComponent<Rigidbody>();

            bulletPhysic.AddForce(currentBullet.transform.forward * this.turretStrength);
        }
    }
}
