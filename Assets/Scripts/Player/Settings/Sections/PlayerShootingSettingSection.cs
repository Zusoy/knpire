using UnityEngine;

namespace Knpire.Player.Settings.Sections
{
    [System.Serializable]
    public class PlayerShootingSettingSection
    {
        [Header("The Bullet Game Object")]
        public GameObject Bullet;

        [Header("Tank Turret Strength")]
        public float TurretStrength;
    }
}
