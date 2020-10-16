using UnityEngine;

namespace Knpire.Player.Settings
{
    using Sections;

    [CreateAssetMenu(fileName = "Player Settings", menuName = "Settings/Player")]
    public class PlayerSetting : ScriptableObject
    {
        public PlayerMovementSettingSection Movement;
        public PlayerShootingSettingSection Shooting;
    }
}
