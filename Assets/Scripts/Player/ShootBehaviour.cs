using UnityEngine;

namespace Knpire.Player
{
    using Common;
    using Settings;

    /// <summary>
    /// Handle Player Shooting
    /// </summary>
    public class ShootBehaviour : ConfigurableMonoBehaviour<PlayerSetting>
    {
        [SerializeField]
        [Header("Position of bullet to spawn on Tank")]
        private Transform shootPoint;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                this.Shoot();
            }
        }

        private void Shoot()
        {
            GameObject currentBullet = Instantiate(
                this.settings.Shooting.Bullet, 
                this.shootPoint.transform.position, 
                this.transform.rotation
            );

            Rigidbody bulletPhysic = currentBullet.GetComponent<Rigidbody>();

            bulletPhysic.AddForce(currentBullet.transform.forward * this.settings.Shooting.TurretStrength);
        }
    }
}
